﻿#region Greenshot GNU General Public License

// Greenshot - a free and open source screenshot tool
// Copyright (C) 2007-2018 Thomas Braun, Jens Klingen, Robin Krom
// 
// For more information see: http://getgreenshot.org/
// The Greenshot project is hosted on GitHub https://github.com/greenshot/greenshot
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 1 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

#endregion

using System.Diagnostics.CodeAnalysis;
using Dapplo.Config.Language;

namespace Greenshot.Addon.Jira.Configuration.Impl
{
    [SuppressMessage("ReSharper", "UnassignedGetOnlyAutoProperty")]
    public class JiraLanguageImpl : LanguageBase<IJiraLanguage>, IJiraLanguage
    {
        #region Implementation of IJiraLanguage

        public string Cancel { get; }
        public string ColumnAssignee { get; }
        public string ColumnCreated { get; }
        public string ColumnId { get; }
        public string ColumnReporter { get; }
        public string ColumnSummary { get; }
        public string CommunicationWait { get; }
        public string LabelComment { get; }
        public string LabelFilename { get; }
        public string LabelJira { get; }
        public string LabelJirafilter { get; }
        public string LabelUploadFormat { get; }
        public string LabelUrl { get; }
        public string LoginError { get; }
        public string LoginTitle { get; }
        public string Ok { get; }
        public string SettingsTitle { get; }
        public string UploadFailure { get; }
        public string UploadMenuItem { get; }
        public string UploadSuccess { get; }

        #endregion
    }
}
