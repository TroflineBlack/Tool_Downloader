using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Net;

WriteDelayed("Press any key to start the program =)",100);

try
{
    DoCode();
}
catch (Exception e)
{
    Console.Clear();
    Console.WriteLine(e);
    Console.ReadKey();
    Process.GetCurrentProcess().Kill();
}


void DoCode()
{
	RootCheck();
    ToolDownloader();
}

void ToolDownloader()
{
    while (Variables.loop == true)
    {
        Console.Clear();

        ListTools();

        var readKey = Console.ReadKey().Key;

        switch (readKey)
        {
            case ConsoleKey.S:
                if (File.Exists(Variables.parDir + "\\Vanilla-Mod_Switcher"))
                {
                    File.Delete(Variables.parDir + "\\Vanilla-Mod_Switcher");
                }

                using (WebClient webClient = new WebClient())
                {
                    webClient.DownloadFile("https://www.speedrun.com/resourceasset/68bb6", $@"{Variables.parDir}\Vanilla-Mod_Switcher.rar");
                }
                break;

            case ConsoleKey.D:
                if (File.Exists(Variables.parDir + "\\DefaultInput_Creator"))
                {
                    File.Delete(Variables.parDir + "\\DefaultInput_Creator");
                }

                using (WebClient webClient = new WebClient())
                {
                    webClient.DownloadFile("https://www.speedrun.com/resourceasset/mf6ch", $@"{Variables.parDir}\DefaultInput_Creator.zip");
                }
                break;

            case ConsoleKey.B:
                if (File.Exists(Variables.parDir + "\\BetterOutlastLauncher.bat"))
                {
                    File.Delete(Variables.parDir + "\\BetterOutlastLauncher.bat");
                }

                using (WebClient webClient = new WebClient())
                {
                    webClient.DownloadFile("https://cdn.discordapp.com/attachments/912123109895725066/938933238838231080/BetterOutlastLauncher.bat", $@"{Variables.parDir}\BetterOutlastLauncher.bat");
                }
                break;

            case ConsoleKey.L:
                if (File.Exists(Variables.parDir + "\\SuperbooOLSRHelper_ribz5"))
                {
                    File.Delete(Variables.parDir + "\\SuperbooOLSRHelper_ribz5");
                }

                using (WebClient webClient = new WebClient())
                {
                    webClient.DownloadFile("https://www.speedrun.com/resourceasset/ribz5", $@"{Variables.parDir}\SuperbooOLSRHelper_ribz5.zip");
                }
                break;

            case ConsoleKey.N:
                if (File.Exists(Variables.parDir + "\\NohBoard-ReWrite-v1.3.0"))
                {
                    File.Delete(Variables.parDir + "\\NohBoard-ReWrite-v1.3.0");
                }

                using (WebClient webClient = new WebClient())
                {
                    webClient.DownloadFile("https://github.com/ThoNohT/NohBoard/releases/download/v1.3.0/NohBoard-ReWrite-v1.3.0.zip", $@"{Variables.parDir}\NohBoard-ReWrite-v1.3.0.zip");
                }
                break;

            case ConsoleKey.T:
                if (File.Exists(Variables.parDir + "\\LiveSplit_1.8.21"))
                {
                    File.Delete(Variables.parDir + "\\LiveSplit_1.8.21");
                }

                using (WebClient webClient = new WebClient())
                {
                    webClient.DownloadFile("https://github.com/LiveSplit/LiveSplit/releases/download/1.8.21/LiveSplit_1.8.21.zip", $@"{Variables.parDir}\LiveSplit_1.8.21.zip");
                }
                break;

            case ConsoleKey.P:

                if (File.Exists(Variables.parDir + "\\Path-File_Opener"))
                {
                    File.Delete(Variables.parDir + "\\Path-File_Opener");
                }

                using (WebClient webClient = new WebClient())
                {
                    webClient.DownloadFile("https://github.com/TroflineBlack/Current-Version/releases/latest/download/Path-File_Opener.zip", $@"{Variables.parDir}\Path-File_Opener.zip");
                }
                break;

            case ConsoleKey.H:

                if (File.Exists(Variables.parDir + "\\Outlast_Speedrun-Helper_v1.0.exe"))
                {
                    File.Delete(Variables.parDir + "\\Outlast_Speedrun-Helper_v1.0.exe");
                }

                using (WebClient webClient = new WebClient())
                {
                webClient.DownloadFile("https://www.speedrun.com/resourceasset/jpm1w", $@"{Variables.parDir}\Outlast Speedrun-Helper v1.0.exe");
                }

                break;

        case ConsoleKey.Spacebar:
                DescribeTools();
            break;

        case ConsoleKey.Escape:
                Process.GetCurrentProcess().Kill();
            break;

            default:
            continue;   
        }
    }
}

void DescribeTools()
{
    reloop:

    Console.Clear();

    ListDescriptions();

    var readKey = Console.ReadKey().Key;

        switch (readKey)
        {
            case ConsoleKey.S:          //Vanilla-Mod_Switcher
            
                Console.Clear();

                WriteDelayed("A rule says that you have to use vanilla (unmodded) content of outlast. With this tool you can simply switch from modded to unmodded or the opposite thing to quickly change and run the game.. It will automatically detect if you are using vanilla/modded... Little timesaver as a glitch-hunter and speedrunner :3", 100);

                Console.ReadKey();
                break;

            case ConsoleKey.D:          //DefaultInput_Creator

                Console.Clear();

                WriteDelayed("With this tool you can create keybinds to stuff like ingame collision or show fps etc... so you glitch hunt or train better...", 100);

                Console.ReadKey();
                break;

            case ConsoleKey.B:          //32-Bit_Launcher

                Console.Clear();

                WriteDelayed("This needs to be put in your outlast folder. It's useful for when your doing drying ground boostup on amd (which you need the 32 bit version to do when on amd) or for if you just want to launch it without steam.", 100);

                Console.ReadKey();
                break;

            case ConsoleKey.L:          //Level_Launcher

                Console.Clear();

                WriteDelayed("This mod includes a custom menu, that allows you to easily run commands, along with that is a command line you can type into. More details are in the text document included in this zip. DON'T USE FOR RUNS, ONLY PRACTICE.", 100);

                Console.ReadKey();
                break;

            case ConsoleKey.N:          //NohBoard
            
                Console.Clear();

                WriteDelayed("NohBoard is an attempt at making a free/open source keyboard visualizer with as much customization possibilities as posisble. It's main use is for livestreamers that want to overlay their currently pressed keys on their streams. But feel free to use it for any other purpose as well.",100);

                Console.ReadKey();
                break;

            case ConsoleKey.T:          //LiveSplit

                Console.Clear();

                WriteDelayed("SourceSplit is a component that helps out Source engine speedrunning. It can automatically split for you when a map changes, and it keeps track of in-game time so you don't have to record demos. It works by reading the game's memory, and it should work on every Source engine game.",100);

                Console.ReadKey();
                break;

            case ConsoleKey.P:          //Path-File_Opener
            
                Console.Clear();

                WriteDelayed("With this tool you can create presets in which you can enter folder or file paths. So if you are a speedrunner, you might know the thing about opening 6 files at once. With this tool you can put several paths into a preset and start everything faster and easier instead of using shortcuts ;D So a single press of a button is enough start everything like Nohboard,Outlast(Bit-Version),OBS,Livesplit etc",100);

                Console.ReadKey();
                break;

            case ConsoleKey.H:          //SpeedrunHelper

                Console.Clear();

                WriteDelayed("Usage: -Trainer-Mode- *Press Ctrl+(F1-F4) to save up to 4 locations *Press F1-F4 to restore those locations -General- *Press END to close the tool", 100);

                Console.ReadKey();
                break;

        case ConsoleKey.Backspace:      //Return
            break;

        case ConsoleKey.Escape:         //Exit
            Process.GetCurrentProcess().Kill();
            break;

        default:
        goto reloop;
        }
}

void ListDescriptions()
{
    WriteDelayed($"\nPress [S] to get describtions of the tool ,,Vanilla-Mod_Switcher''\n", 100);
    WriteDelayed($"Press [D] to get describtions of the tool ,,DefaultInput_Creator''\n", 100);
    WriteDelayed($"Press [B] to get describtions of the tool ,,32-Bit Launcher''\n", 100);
    WriteDelayed($"Press [L] to get describtions of the tool ,,Level_Launcher''\n", 100);
    WriteDelayed($"Press [N] to get describtions of the tool ,,NohBoard''\n", 100);
    WriteDelayed($"Press [T] to get describtions of the tool ,,LiveSplit''\n", 100);
    WriteDelayed($"Press [P] to get describtions of the tool ,,Path-File_Opener''\n", 100);
    WriteDelayed($"Press [H] to get describtions of the tool ,,Outlast Speedrun-Helper''\n", 100);
    WriteDelayed($"\n\nPress [BACKSPACE] to return to the downloading tool page\n", 100);
    WriteDelayed($"Press [ESCAPE] to exit this program\n", 100);
}

void ListTools()
{
    WriteDelayed($"\nPress [S] to download the tool ,,Vanilla-Mod_Switcher''\n",100);
    WriteDelayed($"Press [D] to download the tool ,,DefaultInput_Creator''\n", 100);
    WriteDelayed($"Press [B] to download the tool ,,32-Bit Launcher''\n", 100);
    WriteDelayed($"Press [L] to download the tool ,,Level_Launcher''\n", 100);
    WriteDelayed($"Press [N] to download the tool ,,NohBoard''\n", 100);
    WriteDelayed($"Press [T] to download the tool ,,LiveSplit''\n", 100);
    WriteDelayed($"Press [P] to download the tool ,,Path-File_Opener''\n", 100);
    WriteDelayed($"Press [H] to download the tool ,,Outlast Speedrun-Helper''\n", 100);
    WriteDelayed($"\n\nPress [SPACEBAR] to get describtions of all the tools\n", 100);
    WriteDelayed($"Press [ESCAPE] to exit this program\n", 100);
}

void RootCheck()
{
	if (!File.Exists(Variables.parDir + "\\OutlastLauncher.exe"))
	{
        WriteDelayed($"This program is located in\n{Variables.curDir}\nPlease move this folder to the root folder of Outlast",100);
        Console.ReadKey();
        Process.GetCurrentProcess().Kill();
	}
}

void WriteDelayed(string messagge, int timer)
{
    Console.WriteLine(messagge);
    Thread.Sleep(timer);
}

static class Variables
{
    public static readonly string curDir = Directory.GetCurrentDirectory();
    public static readonly string parDir = Directory.GetParent(Directory.GetCurrentDirectory()).ToString();
    public static readonly bool loop = true;
    public static readonly ConsoleKey readKey = Console.ReadKey().Key;
}