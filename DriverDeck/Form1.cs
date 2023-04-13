using System.Diagnostics;
using System.Runtime.InteropServices;

namespace DriverDeck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public enum KnownFolder
        {
            Contacts,
            Downloads,
            Favorites,
            Links,
            SavedGames,
            SavedSearches
        }
        public static class KnownFolders
        {
            private static readonly Dictionary<KnownFolder, Guid> _guids = new()
            {
                [KnownFolder.Contacts] = new("56784854-C6CB-462B-8169-88E350ACB882"),
                [KnownFolder.Downloads] = new("374DE290-123F-4565-9164-39C4925E467B"),
                [KnownFolder.Favorites] = new("1777F761-68AD-4D8A-87BD-30B759FA33DD"),
                [KnownFolder.Links] = new("BFB9D5E0-C6A9-404C-B2B2-AE6DB6AF4968"),
                [KnownFolder.SavedGames] = new("4C5C32FF-BB9D-43B0-B5B4-2D72E54EAAA4"),
                [KnownFolder.SavedSearches] = new("7D1D3A04-DEBB-4115-95CF-2F29DA2920DA")
            };

            public static string GetPath(KnownFolder knownFolder)
            {
                return SHGetKnownFolderPath(_guids[knownFolder], 0);
            }

            [DllImport("shell32",
                CharSet = CharSet.Unicode, ExactSpelling = true, PreserveSig = false)]
            private static extern string SHGetKnownFolderPath(
                [MarshalAs(UnmanagedType.LPStruct)] Guid rfid, uint dwFlags,
                nint hToken = 0);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Google Chrome
                Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:https://dl.google.com/tag/s/appguid%3D%7B8A69D345-D564-463C-AFF1-A69D9E530F96%7D%26iid%3D%7B3D952389-7455-643F-DB24-79664E897C62%7D%26lang%3Den%26browser%3D5%26usagestats%3D0%26appname%3DGoogle%2520Chrome%26needsadmin%3Dprefers%26ap%3Dx64-stable-statsdef_1%26brand%3DVDKB%26installdataindex%3Dempty/update2/installers/ChromeSetup.exe") { CreateNoWindow = true });
                Thread.Sleep(100);
            }
            if (checkBox2.Checked)
            {
                // Discord
                Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:https://dl.discordapp.net/distro/app/stable/win/x86/1.0.9012/DiscordSetup.exe") { CreateNoWindow = true });
                Thread.Sleep(100);
            }
            if (checkBox3.Checked)
            {
                // Steam
                Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:https://cdn.cloudflare.steamstatic.com/client/installer/SteamSetup.exe") { CreateNoWindow = true });
                Thread.Sleep(100);
            }
            if (checkBox4.Checked)
            {
                // Notepad++
                Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:https://github.com/notepad-plus-plus/notepad-plus-plus/releases/download/v8.5.2/npp.8.5.2.Installer.x64.exe") { CreateNoWindow = true });
                Thread.Sleep(100);
            }
            if (checkBox5.Checked)
            {
                // Battle.net
                Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:https://www.battle.net/download/getInstallerForGame?os=win&gameProgram=BATTLENET_APP&version=Live&id=1291358105.1681401064&_gl=1*1hf6kym*_ga*MTI5MTM1ODEwNS4xNjgxNDAxMDY0*_ga_VYKNV7C0S3*MTY4MTQwMTA2NC4xLjAuMTY4MTQwMTA2NC42MC4wLjA.") { CreateNoWindow = true });
                Thread.Sleep(100);
            }
            if (checkBox6.Checked)
            {
                // Github Desktop
                Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:https://central.github.com/deployments/desktop/desktop/latest/win32") { CreateNoWindow = true });
                Thread.Sleep(100);
            }
            if (checkBox7.Checked)
            {
                // Visual Studio 2022
                Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022&source=VSLandingPage&cid=2030&passive=false") { CreateNoWindow = true });
                Thread.Sleep(100);
            }
            if (checkBox8.Checked)
            {
                // 7zip
                Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:https://www.7-zip.org/a/7z2201-x64.exe") { CreateNoWindow = true });
                Thread.Sleep(100);
            }
            if (checkBox9.Checked)
            {
                // Visual Studio Code
                Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:https://az764295.vo.msecnd.net/stable/704ed70d4fd1c6bd6342c436f1ede30d1cff4710/VSCodeUserSetup-x64-1.77.3.exe") { CreateNoWindow = true });
                Thread.Sleep(100);
            }
            if (checkBox10.Checked)
            {
                // EA Launcher
                Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:https://origin-a.akamaihd.net/EA-Desktop-Client-Download/installer-releases/EAappInstaller.exe") { CreateNoWindow = true });
                Thread.Sleep(100);
            }
            if (checkBox11.Checked)
            {
                // Uplay Launcher
                Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:https://origin-a.akamaihd.net/EA-Desktop-Client-Download/installer-releases/EAappInstaller.exe") { CreateNoWindow = true });
                Thread.Sleep(100);
            }
            if (checkBox12.Checked)
            {
                // Modded Spotify
                Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:https://github.com/amd64fox/SpotX/archive/refs/heads/main.zip") { CreateNoWindow = true });
                Thread.Sleep(100);
                MessageBox.Show("Unzip and run install.ps1");
            }
            if (checkBox13.Checked)
            {
                // AMD Radeon GPU Driver
                Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:https://drivers.amd.com/drivers/installer/22.40/whql/amd-software-adrenalin-edition-23.4.1-minimalsetup-230405_web.exe") { CreateNoWindow = true });
                Thread.Sleep(100);
            }
            if (checkBox14.Checked)
            {
                // NVIDIA GPU Driver
                Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:https://us.download.nvidia.com/GFE/GFEClient/3.27.0.112/GeForce_Experience_v3.27.0.112.exe") { CreateNoWindow = true });
                Thread.Sleep(100);
            }
            if (checkBox15.Checked)
            {
                // Kayla's Drivers <3
                Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:https://download.msi.com/dvr_exe/mb/amd_chipset_drivers_am4_wt.zip") { CreateNoWindow = true });
                Thread.Sleep(100);

                Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:https://download.msi.com/dvr_exe/mb/realtek_audio_R.zip") { CreateNoWindow = true });
                Thread.Sleep(100);

                Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:https://download.msi.com/dvr_exe/mb/intel_wifi_driver_WT.zip") { CreateNoWindow = true });
                Thread.Sleep(100);

                Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:https://download.msi.com/dvr_exe/mb/bt_driver_WT.zip") { CreateNoWindow = true });
                Thread.Sleep(100);

                Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:https://download.msi.com/dvr_exe/mb/realtek_pcielan_w10.zip") { CreateNoWindow = true });
                Thread.Sleep(100);

                Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:https://drivers.amd.com/drivers/installer/22.40/whql/amd-software-adrenalin-edition-23.4.1-minimalsetup-230405_web.exe") { CreateNoWindow = true });
                Thread.Sleep(100);
            }
            if (checkBox16.Checked)
            {
                // Super F4
                Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:https://github.com/stefansundin/superf4/releases/download/v1.4/SuperF4-1.4.exe") { CreateNoWindow = true });
                Thread.Sleep(100);
            }
            if (checkBox17.Checked)
            {
                // AutoHotKey
                Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:https://www.autohotkey.com/download/ahk-install.exe") { CreateNoWindow = true });
                Thread.Sleep(100);
            }
            if (checkBox18.Checked)
            {
                // AutoHotKey v2
                Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:https://www.autohotkey.com/download/ahk-v2.exe") { CreateNoWindow = true });
                Thread.Sleep(100);
            }
            if (checkBox19.Checked)
            {
                // Python
                Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:https://www.python.org/ftp/python/3.11.3/python-3.11.3-amd64.exe") { CreateNoWindow = true });
                Thread.Sleep(100);
            }
            if (checkBox20.Checked)
            {
                // Minecraft Old
                Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:https://aka.ms/minecraftClientWindows") { CreateNoWindow = true });
                Thread.Sleep(100);
            }
            if (checkBox21.Checked)
            {
                // Minecraft New
                Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:https://aka.ms/minecraftClientGameCoreWindows") { CreateNoWindow = true });
                Thread.Sleep(100);
            }
            if (checkBox22.Checked)
            {
                // Epic Games
                Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:https://launcher-public-service-prod06.ol.epicgames.com/launcher/api/installer/download/EpicGamesLauncherInstaller.msi") { CreateNoWindow = true });
                Thread.Sleep(100);
            }
            if (checkBox23.Checked)
            {
                // Process Killer
                Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:https://github.com/Spinchies/Process-Killer/releases/download/Process-Killer/ProcessKiller.exe") { CreateNoWindow = true });
                Thread.Sleep(100);
            }
            if (checkBox24.Checked)
            {
                // Windows Terminal
                Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:https://github.com/microsoft/terminal/releases/download/v1.16.10261.0/Microsoft.WindowsTerminal_Win10_1.16.10261.0_8wekyb3d8bbwe.msixbundle") { CreateNoWindow = true });
                Thread.Sleep(100);
            }
            if (checkBox25.Checked)
            {
                // Rufus
                Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:https://github.com/pbatard/rufus/releases/download/v3.22/rufus-3.22.exe") { CreateNoWindow = true });
                Thread.Sleep(100);
            }
            if (checkBox26.Checked)
            {
                // Razer Synapse
                var confirmResult = MessageBox.Show("Do you want to download Razer 7.1 Surround Sound as well?",
                                     "Additional Software",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:https://rzr.to/synapse-3-pc-download") { CreateNoWindow = true });
                    Thread.Sleep(100);
                    Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:https://rzr.to/71-surround-sound-installer") { CreateNoWindow = true });
                    Thread.Sleep(100);
                }
                else
                {
                    Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:https://rzr.to/synapse-3-pc-download") { CreateNoWindow = true });
                    Thread.Sleep(100);
                }
                Thread.Sleep(100);
            }
            if (checkBox27.Checked)
            {
                // Corsair iCue
                Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:https://downloads.corsair.com/Files/CUE/iCUESetup_4.33.138_release.msi") { CreateNoWindow = true });
                Thread.Sleep(100);
            }
            if (checkBox28.Checked)
            {
                // qFlipper
                Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:https://update.flipperzero.one/builds/qFlipper/1.3.0/qFlipperSetup-64bit-1.3.0.exe") { CreateNoWindow = true });
                Thread.Sleep(100);
            }
            if (checkBox29.Checked)
            {
                // Iobit Unlocker
                Process.Start(new ProcessStartInfo("cmd", $"/c start microsoft-edge:https://cdn.iobit.com/dl/unlocker-setup.exe") { CreateNoWindow = true });
                Thread.Sleep(100);
            }
            string downloadsPath = KnownFolders.GetPath(KnownFolder.Downloads);
            string dir = downloadsPath;
            try
            {
                //Set the current directory.
                Directory.SetCurrentDirectory(dir);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The specified directory does not exist. {0}");
            }
        }
        // Everything below is empty atm
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}