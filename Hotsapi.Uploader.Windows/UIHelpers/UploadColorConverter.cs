﻿using Hotsapi.Uploader.Common;
using System;
using System.Linq;
using System.Windows.Media;

namespace Hotsapi.Uploader.Windows.UIHelpers
{
    public class UploadColorConverter : GenericValueConverter<UploadStatus, Brush>
    {
        protected override Brush Convert(UploadStatus value)
        {
            switch (value) {
                case UploadStatus.Success:
                    return new SolidColorBrush(Colors.Green);

                case UploadStatus.InProgress:
                    return new SolidColorBrush(Colors.Orange);

                case UploadStatus.Duplicate:
                case UploadStatus.AiDetected:
                case UploadStatus.CustomGame:
                case UploadStatus.PtrRegion:
                case UploadStatus.TooOld:
                    return new SolidColorBrush(Colors.DarkGray);

                case UploadStatus.None:
                case UploadStatus.UploadError:
                case UploadStatus.Incomplete:
                default:
                    return new SolidColorBrush(Colors.Red);
            }
        }
    }
}
