﻿// Copyright © 2015 Daniel Porrey. All Rights Reserved.
//
// This file is part of the IoT Devices and Sensors project.
// 
// IoT Devices and Sensors is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// IoT Devices and Sensors is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with IoT Devices and Sensors. If not, 
// see http://www.gnu.org/licenses/.
//
using Windows.Devices.Gpio;

namespace Porrey.Uwp.IoT.FluentApi
{
	/// <summary>
	/// Interface definition for the configuration information used to
	/// construct a GPIO pin taking single parameters at a time via the
	/// fluent API.
	/// </summary>
	public interface IGpioPinConfiguration
	{
		/// <summary>
		/// Gets/sets a reference to the GPIO controller
		/// </summary>
		GpioController Gpio { get; set; }

		/// <summary>
		/// Gets/sets the pin number on the GPIO
		/// controller to be initialized.
		/// </summary>
		int PinNumber { get; set; }

		/// <summary>
		/// Get/sets the sharing mode to be used on the pin.
		/// </summary>
		GpioSharingMode SharingMode { get; set; }
	}
}
