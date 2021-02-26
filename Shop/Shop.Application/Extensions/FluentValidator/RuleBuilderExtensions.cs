using FluentValidation;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Shop.Application.Extensions.FluentValidator
{
    public static class RuleBuilderExtensions
    {
        //Declare format string regex
        private static readonly string patternTacitCode = @"^[A-Z]{4}[0-9]{5}$";

        private static readonly string patternPopName = @"^[A-Z]{4}[0-9]{3}$";
        private static readonly string patternBellowName = @"^[A-Z]{4}[0-9]{5}.[0-9]{3}\/[B]{1}$";
        private static readonly string patternGanivoName = @"^[A-Z]{4}[0-9]{5}.[0-9]{3}\/[G]{1}$";
        private static readonly string patternDeviceName = @"^[A-Z]{4}[0-9]{5}.[0-9]{3}\/[A-Z]{1}$";
        private static readonly string patternSizeBellow = @"^\S\d*\.?\d*[X]\S\d*\.?\d*[X]\S\d*\.?\d*$";
        private static readonly string patternPosition = @"^[-]?\d*[ ][-]?\d*$";
        private static readonly string patternPhoneNumber = @"/(03|05|07|08|09|01[2|6|8|9])+([0-9]{8})\b/";
        private static readonly string patternTubeName = @"^[A-Z]{4}[0-9]{5}.[0-9]{3}/[D]{1}$";
        private static readonly string patternPipePlugName = @"^[A-Z]{4}[0-9]{5}.[0-9]{3}/[O]{1}$";
        private static readonly string patternTubeDetailName = @"^[A-Z]{4}[0-9]{5}.[0-9]{3}\/[D]{1}.[0-9A-Z]{2}$";
        private static readonly string patternPipePlugDetailName = @"^[A-Z]{4}[0-9]{5}.[0-9]{3}\/[O]{1}.[0-9A-Z]{2}$";
        private static readonly string patternCablePonName = @"^[A-Z]{4}[0-9]{3}.[0-9]{4}\/[CO|CU|SO]{2}$";
        private static readonly string patternCableRTName = @"^[A-Z]{4}[0-9]{6}\/[CO|CU|SO]{2}$";

        #region CUSTOM_VALIDATION_COMMON

        public static IRuleBuilderOptions<T, string> RegexTacitCode<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.Must(tacitCode => CheckRegexTacitCode(tacitCode))
                .WithMessage("Mã Công Trình không hợp lệ");
        }

        public static IRuleBuilderOptions<T, string> RegexPopName<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.Must(popName => CheckRegexPopName(popName))
                .WithMessage("Tên Pop không hợp lệ");
        }

        public static IRuleBuilderOptions<T, string> RegexBellowName<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.Must(bellowName => CheckRegexBellowName(bellowName))
                .WithMessage("Tên Bể Cáp không hợp lệ");
        }

        public static IRuleBuilderOptions<T, string> RegexGanivoName<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.Must(ganivoName => CheckRegexGanivoName(ganivoName))
                .WithMessage("Tên Ganivo không hợp lệ");
        }

        public static IRuleBuilderOptions<T, string> RegexDeviceName<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.Must(deviceName => CheckRegexDeviceName(deviceName))
                .WithMessage("Tên Thiết Bị không hợp lệ");
        }

        public static IRuleBuilderOptions<T, string> RegexSizeBellow<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.Must(Size => CheckRegexSizeBellow(Size))
                .WithMessage("Kích thước không hợp lệ");
        }

        public static IRuleBuilderOptions<T, string> RegexPosition<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.Must(Pos => CheckRegexPosition(Pos))
                .WithMessage("Tọa độ không đúng định dạng");
        }

        public static IRuleBuilderOptions<T, string> IsDeviceWithConnectTypeValid<T>(this IRuleBuilder<T, string> ruleBuilder, int typeConnect)
        {
            // typeConnect: 2 - Bể | 3 - Ganivo
            return ruleBuilder.Must(deviceName => IsDeviceWithConnectTypeValid(deviceName, typeConnect))
                .WithMessage("Thiết bị không thuộc loại kết nối hiện tại");
        }

        public static IRuleBuilderOptions<T, string> IsNumber<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            //validate number
            return ruleBuilder.Must(number => IsNumber(number))
                .WithMessage("Sai định dạng kiểu số nguyên, Vui lòng kiểm tra lại");
        }

        public static IRuleBuilderOptions<T, string> IsDateTime<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            //validate number
            return ruleBuilder.Must(date => IsDateTime(date))
                .WithMessage("Sai định dạng ngày tháng năm, Vui lòng kiểm tra lại");
        }

        public static IRuleBuilderOptions<T, string> RegexPhoneNumber<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.Must(phoneNumber => CheckRegexPhoneNumber(phoneNumber))
                .WithMessage("Số điện thoại không hợp lệ");
        }

        public static IRuleBuilderOptions<T, string> RegexTubeName<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.Must(tubeName => CheckRegexTubeName(tubeName))
                .WithMessage("Tên đoạn ống không hợp lệ");
        }

        public static IRuleBuilderOptions<T, string> RegexTubeDetailName<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.Must(tubeDetailName => CheckRegexTubeDetailName(tubeDetailName))
                .WithMessage("Tên pi của đoạn ống không hợp lệ");
        }

        public static IRuleBuilderOptions<T, string> RegexPipePlugName<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.Must(pipePlugName => CheckRegexPipePlugName(pipePlugName))
                .WithMessage("Tên ống ngoi không hợp lệ");
        }

        public static IRuleBuilderOptions<T, string> RegexPipePlugDetailName<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.Must(pipePlugDetailName => CheckRegexPipePlugDetailName(pipePlugDetailName))
                .WithMessage("Tên pi của ống ngoi không hợp lệ");
        }

        public static IRuleBuilderOptions<T, int> IsExistInArray<T>(this IRuleBuilder<T, int> ruleBuilder, int[] arr)
        {
            return ruleBuilder.Must(item => CheckIsInArray(arr, item))
                .WithMessage("Không nằm trong danh sách cho phép");
        }

        public static IRuleBuilderOptions<T, string> IsExistInArray<T>(this IRuleBuilder<T, string> ruleBuilder, string[] arr)
        {
            return ruleBuilder.Must(item => CheckIsInArray(arr, item))
                .WithMessage("Không nằm trong danh sách cho phép");
        }

        public static IRuleBuilderOptions<T, string> RegexCablePonName<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.Must(cableName => CheckRegexCablePonName(cableName))
                .WithMessage("Tên Cable không hợp lệ");
        }

        public static IRuleBuilderOptions<T, string> RegexCableRTName<T>(this IRuleBuilder<T, string> ruleBuilder)
        {
            return ruleBuilder.Must(cableName => CheckRegexCableRTName(cableName))
                .WithMessage("Tên Cable không hợp lệ");
        }

        #endregion CUSTOM_VALIDATION_COMMON

        #region Function Regex by static patterns

        private static bool CheckRegexTacitCode(string tacitCode)
        {
            var regex = new Regex(patternTacitCode);
            return regex.IsMatch(tacitCode);
        }

        private static bool CheckRegexPopName(string popName)
        {
            var regex = new Regex(patternPopName);
            return regex.IsMatch(popName);
        }

        private static bool CheckRegexBellowName(string bellowName)
        {
            var regex = new Regex(patternBellowName);
            return regex.IsMatch(bellowName);
        }

        private static bool CheckRegexGanivoName(string ganivoName)
        {
            var regex = new Regex(patternGanivoName);
            return regex.IsMatch(ganivoName);
        }

        private static bool CheckRegexDeviceName(string deviceName)
        {
            var regex = new Regex(patternDeviceName);
            return regex.IsMatch(deviceName);
        }

        private static bool CheckRegexPosition(string Pos)
        {
            var regex = new Regex(patternPosition);
            return regex.IsMatch(Pos);
        }

        private static bool IsDeviceWithConnectTypeValid(string deviceName, int typeConnect)
        {
            bool result = false;
            if (typeConnect == 2)
            {
                result = deviceName.EndsWith("B");
            }
            else if (typeConnect == 3)
            {
                result = deviceName.EndsWith("G");
            }
            return result;
        }

        private static bool IsNumber(string number)
        {
            var isNumber = float.TryParse(number, out float n);
            if (isNumber)
                return true;
            else
                return false;
        }

        private static bool CheckRegexSizeBellow(string Size)
        {
            var regex = new Regex(patternSizeBellow);
            return regex.IsMatch(Size);
        }

        private static bool IsDateTime(string Date)
        {
            var isDate = DateTime.TryParse(Date, out DateTime n);
            return isDate;
        }

        private static bool CheckRegexPhoneNumber(string phoneNumber)
        {
            var regex = new Regex(patternPhoneNumber);
            return regex.IsMatch(phoneNumber);
        }

        private static bool CheckRegexTubeName(string tubeName)
        {
            var regex = new Regex(patternTubeName);
            return regex.IsMatch(tubeName);
        }

        private static bool CheckRegexPipePlugName(string pipePlugName)
        {
            var regex = new Regex(patternPipePlugName);
            return regex.IsMatch(pipePlugName);
        }

        private static bool CheckRegexTubeDetailName(string tubeDetailName)
        {
            var regex = new Regex(patternTubeDetailName);
            return regex.IsMatch(tubeDetailName);
        }

        private static bool CheckRegexPipePlugDetailName(string pipePlugDetailName)
        {
            var regex = new Regex(patternPipePlugDetailName);
            return regex.IsMatch(pipePlugDetailName);
        }

        private static bool CheckIsInArray(int[] arr, int item)
        {
            return arr.Contains(item);
        }

        private static bool CheckIsInArray(string[] arr, string item)
        {
            return arr.Contains(item);
        }

        private static bool CheckRegexCablePonName(string cableName)
        {
            var regex = new Regex(patternCablePonName);
            return regex.IsMatch(cableName);
        }

        private static bool CheckRegexCableRTName(string cableName)
        {
            var regex = new Regex(patternCableRTName);
            return regex.IsMatch(cableName);
        }
    }

    #endregion Function Regex by static patterns
}
