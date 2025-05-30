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

using System.Runtime.CompilerServices;

#if SignAssembly
[assembly: InternalsVisibleTo("SonarScanner.Integration.Tasks.UnitTest,PublicKey=002400000480000094000000060200000024000052534131000400000100010081b4345a022cc0f4b42bdc795a5a7a1623c1e58dc2246645d751ad41ba98f2749dc5c4e0da3a9e09febcb2cd5b088a0f041f8ac24b20e736d8ae523061733782f9c4cd75b44f17a63714aced0b29a59cd1ce58d8e10ccdb6012c7098c39871043b7241ac4ab9f6b34f183db716082cd57c1ff648135bece256357ba735e67dc6")]
[assembly: InternalsVisibleTo("SonarScanner.MSBuild.Tasks.UnitTest,PublicKey=002400000480000094000000060200000024000052534131000400000100010081b4345a022cc0f4b42bdc795a5a7a1623c1e58dc2246645d751ad41ba98f2749dc5c4e0da3a9e09febcb2cd5b088a0f041f8ac24b20e736d8ae523061733782f9c4cd75b44f17a63714aced0b29a59cd1ce58d8e10ccdb6012c7098c39871043b7241ac4ab9f6b34f183db716082cd57c1ff648135bece256357ba735e67dc6")]
#else
[assembly: InternalsVisibleTo("SonarScanner.Integration.Tasks.UnitTest")]
[assembly: InternalsVisibleTo("SonarScanner.MSBuild.Tasks.UnitTest")]
#endif
