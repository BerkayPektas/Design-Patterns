using CommandPattern.Classes;
using CommandPattern.Classes.Commands;
using CommandPattern.Interfaces;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            /* Define and instantiate the following Vendor classes
             * Kitchen Light : Light
             * Livingroom Light : Light
             * Livingroom ceiling fan : CeilingFan
             * Garage door: Garagedoor
             * Stereo : Stereo
             */

            Light kitchenLight = new Light("Kitchen");
            Light livingRoomLight = new Light("Living Room");
            Light garageLight = new Light("Garage");
            CeilingFan livingRoomCeilingFan = new CeilingFan("Living Room");
            GarageDoor door = new GarageDoor(garageLight);
            Stereo stereo = new Stereo();

            // Define and instantiate an Off and On command for each Vendor class
            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);
            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);
            CeilingFanHighCommand livingRoomCeilingFanHigh = new CeilingFanHighCommand(livingRoomCeilingFan);
            CeilingFanMediumCommand livingRoomCeilingFanMedium = new CeilingFanMediumCommand(livingRoomCeilingFan);
            CeilingFanLowCommand livingRoomCeilingFanLow = new CeilingFanLowCommand(livingRoomCeilingFan);
            CeilingFanOffCommand livingRoomCeilingFanOff = new CeilingFanOffCommand(livingRoomCeilingFan);
            GarageDoorUpCommand garageDoorUp = new GarageDoorUpCommand(door);
            GarageDoorDownCommand garageDoorDown = new GarageDoorDownCommand(door);
            StereoOnWithCdCommand stereoOnWithCd = new StereoOnWithCdCommand(stereo);
            StereoOnWithDvdCommand stereoOnWithDvd = new StereoOnWithDvdCommand(stereo);
            StereoOnWithRadioCommand stereoOnWithRadio = new StereoOnWithRadioCommand(stereo);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);

            /* Set the On and Off commands to the appropriate slot:
             * 
             * 1: Living Room light
             * 2: Kitchen light
             * 3: Livingroom ceiling fan
             * 4: Garage door
             * 5: Stereo
             */

            remoteControl.SetCommand(1, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(2, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(3, livingRoomCeilingFanMedium, livingRoomCeilingFanOff);
            remoteControl.SetCommand(4, garageDoorUp, garageDoorDown);
            remoteControl.SetCommand(5, stereoOnWithCd, stereoOff);

            Console.WriteLine(remoteControl);

            // Test the pressing of Buttons here. Don't forget to test the Undo button
            remoteControl.OnButtonWasPushed(1);
            remoteControl.OnButtonWasPushed(2);
            remoteControl.OnButtonWasPushed(3);
            remoteControl.OnButtonWasPushed(4);
            remoteControl.OnButtonWasPushed(5);

            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();
            remoteControl.UndoButtonWasPushed();

            Console.WriteLine();
            remoteControl.OffButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(2);
            remoteControl.OffButtonWasPushed(3);
            remoteControl.OffButtonWasPushed(4);
            remoteControl.OffButtonWasPushed(5);
        }
    }
}