using FluentValidation;
using Shop.Application.Common.Interfaces.Repositories.Common;
using Shop.Application.Extensions.FluentValidator;

namespace Shop.Application.Features.TacitWorks.Tacit.Commands.CreateTacit
{
    public class CreateTacitCommandValidator : AbstractValidator<CreateTacitCommand>
    {
        private readonly ICommonRepository _commonRepository;
        public CreateTacitCommandValidator(ICommonRepository commonRepository)
        {
            _commonRepository = commonRepository;
            RuleFor(x => x.LocationID)
                    .NotNull()
                    .WithMessage("Vùng miền không được trống")
                    .MustAsync(async (x,cancellation) => await _commonRepository.IsExistLocation(x))
                    .WithMessage("Vùng miền không tồn tại trên hệ thống");

            RuleFor(x => x.BranchID)
                .NotNull()
                .WithMessage("Chi nhánh không được trống")
                .MustAsync(async (x, BranchID, cancellation) => await _commonRepository.IsExistBranch(x.LocationID, x.BranchID))
                .WithMessage("Chi nhánh không tồn tại trên hệ thống");

            RuleFor(x => x.Plans)
                .NotEmpty()
                .WithMessage("Mã kế hoạch không được trống")
                .Must(x => (x != null ? x.Length : 0) < 50)
                .WithMessage("Mã kế hoạch không vượt quá 50 kí tự")
                .MustAsync(async (x, Plans, cancellation) => await _commonRepository.IsPlanInside(x.Plans))
                .WithMessage("Mã kế hoạch không tồn tại bên inside");

            RuleFor(x => x.Code)
                .NotEmpty()
                .WithMessage("Mã công trình không được trống")
                .RegexTacitCode();

            RuleFor(x => x.TypeBuilding)
                .NotNull()
                .WithMessage("Thuộc building không được trống")
                .InclusiveBetween(0, 1)
                .WithMessage("Bạn chưa chọn building");

            //RuleFor(x => x.TypeBuilding == 1 ? x.BuildingID : 0)
            When(x => x.TypeBuilding == 1, () =>
            {
                RuleFor(x => x.BuildingID)
                    .NotNull()
                    .WithMessage("ID building không được rỗng")
                    .MustAsync(async (x, BuildingID, cancellation) => (x.TypeBuilding != 1 || await _commonRepository.IsBuildingInside(x.LocationID, x.BuildingID, x.BuildingName)))
                    .WithMessage("Building không tồn tại bên inside");
            });

            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Tên công trình không được trống")
                .Must(x => (x != null ? x.Length : 0) < 250)
                .WithMessage("Tên công trình không vượt quá 250 kí tự");

            RuleFor(x => x.INFMaintain)
                .NotEmpty()
                .WithMessage("Khu vực hạ tầng không được trống");

            RuleFor(x => x.Street)
                .NotEmpty()
                .WithMessage("Tuyến đường không được trống")
                .Must(x => (x != null ? x.Length : 0) < 250)
                .WithMessage("Tuyến đường không vượt quá 250 kí tự");

            RuleFor(x => x.Street_Dis)
                .NotNull()
                .WithMessage("Quận tuyến đường không được trống")
                .MustAsync(async (x, Street_Dis, cancellation) => await _commonRepository.IsDistrictWard(x.LocationID, x.Street_Dis, x.Street_War))
                .WithMessage("Quận/huyện, phường/xã tuyến đường không tồn tại");

            RuleFor(x => x.StartName)
                .NotEmpty()
                .WithMessage("Điểm đầu không được trống")
                .Must(x => (x != null ? x.Length : 0) < 250)
                .WithMessage("Điểm đầu không vượt quá 250 kí tự");

            RuleFor(x => x.StartName_Dis)
               .NotNull()
               .WithMessage("Quận điểm đầu không được trống")
               .MustAsync(async (x, StartName_Dis, cancellation) => await _commonRepository.IsDistrictWard(x.LocationID, x.StartName_Dis, x.StartName_War))
               .WithMessage("Quận/huyện, phường/xã điểm đầu không tồn tại");

            RuleFor(x => x.EndName)
                .NotEmpty()
                .WithMessage("Điểm cuối không được trống")
                .Must(x => (x != null ? x.Length : 0) < 250)
                .WithMessage("Điểm cuối không vượt quá 250 kí tự");

            RuleFor(x => x.EndName_Dis)
                .NotNull()
                .WithMessage("Quận điểm cuối không được trống")
                .MustAsync(async (x, EndName_Dis, cancellation) => await _commonRepository.IsDistrictWard(x.LocationID, x.EndName_Dis, x.EndName_War))
                .WithMessage("Quận/huyện, phường/xã điểm cuối không tồn tại");

            RuleFor(x => x.Length)
                .NotEmpty()
                .WithMessage("Chiều dài tuyến không được trống")
                .Must(x => (x != null ? x.Length : 0) < 10)
                .WithMessage("Chiều dài không vượt quá 10 kí tự");
            When(x => !string.IsNullOrEmpty(x.Length), () =>
            {
                RuleFor(x => x.Length).IsNumber();
            });

            RuleFor(x => x.Inves_Costs)
                .NotEmpty()
                .WithMessage("Chi phí đầu tư không được trống")
                .Must(x => (x != null ? x.Length : 0) < 10)
                .WithMessage("Chi phí đầu tư không vượt quá 10 kí tự");

            RuleFor(x => x.Rental_Cost)
              .NotEmpty()
              .WithMessage("Chi phí cho thuê không được trống")
               .Must(x => (x != null ? x.Length : 0) < 10)
               .WithMessage("Chi phí cho thuê không vượt quá 10 kí tự");

            RuleFor(x => x.StartUp_Quarter)
               .NotEmpty()
               .WithMessage("Khởi công không được trống")
               .MustAsync(async (x, cancellation) => await _commonRepository.IsTList(x, 6))
               .WithMessage("Khởi công không tồn tại trên hệ thống");

            RuleFor(x => x.StartUp_Year)
                .NotEmpty()
                .WithMessage("Năm khởi công không được trống")
                .Must((x) =>  _commonRepository.IsYearStartFinish(x))
                .WithMessage("Năm khởi công không tồn tại trên hệ thống");

            RuleFor(x => x.Finish_Quarter)
                .NotEmpty()
                .WithMessage("Hoàn Thành không được trống")
                .MustAsync(async (x,cancellation) => await _commonRepository.IsTList(x, 6))
                .WithMessage("Hoàn Thành không tồn tại trên hệ thống");

            RuleFor(x => x.Finish_Year)
               .NotEmpty()
               .WithMessage("Năm hoàn thành không được trống")
               .Must( (x) =>  _commonRepository.IsYearStartFinish(x))
               .WithMessage("Năm hoàn thành không tồn tại trên hệ thống");

            RuleFor(x => x.InvesID)
              .NotEmpty()
              .WithMessage("Chủ đầu tư không được trống")
              .MustAsync(async (x, cancellation) => await _commonRepository.IsTList(x, 5))
              .WithMessage("Chủ đầu tư không tồn tại trên hệ thống");

            RuleFor(x => x.ManagerUnitID)
             .NotEmpty()
             .WithMessage("Đơn vị quản lý không được trống")
             .MustAsync(async (x, cancellation) => await _commonRepository.IsTList(x, 5))
             .WithMessage("Đơn vị quản lý không tồn tại trên hệ thống");

            RuleFor(x => x.TypeTacit)
             .NotEmpty()
             .WithMessage("Loại công trình không được trống")
             .MustAsync(async (x,cancellation) => await _commonRepository.IsTArray(x, 14))
             .WithMessage("Loại công trình không tồn tại trên hệ thống");
        }
    }
}
