﻿/*
 * SonarScanner for .NET
 * Copyright (C) 2016-2025 SonarSource SA
 * mailto: info AT sonarsource DOT com
 *
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 3 of the License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public License
 * along with this program; if not, write to the Free Software Foundation,
 * Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
 */

using SonarScanner.MSBuild.Common.TFS;

namespace SonarScanner.MSBuild.Common.Interfaces;

public interface IBuildSettings
{
    BuildEnvironment BuildEnvironment { get; }
    string TfsUri { get; }
    string BuildUri { get; }
    string SourcesDirectory { get; }
    string AnalysisBaseDirectory { get; }
    string BuildDirectory { get; }
    string SonarConfigDirectory { get; }
    string SonarOutputDirectory { get; }
    string SonarBinDirectory { get; }
    string AnalysisConfigFilePath { get; }
    string SonarScannerWorkingDirectory { get; }
}
