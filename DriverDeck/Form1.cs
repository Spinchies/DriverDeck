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
            Downloads,
            Links,
        }
        public static class KnownFolders
        {
            private static readonly Dictionary<KnownFolder, Guid> _guids = new()
            {

                [KnownFolder.Downloads] = new("374DE290-123F-4565-9164-39C4925E467B"),
                [KnownFolder.Links] = new("BFB9D5E0-C6A9-404C-B2B2-AE6DB6AF4968"),

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
                var uri = "https://dl.google.com/tag/s/appguid%3D%7B8A69D345-D564-463C-AFF1-A69D9E530F96%7D%26iid%3D%7B3D952389-7455-643F-DB24-79664E897C62%7D%26lang%3Den%26browser%3D5%26usagestats%3D0%26appname%3DGoogle%2520Chrome%26needsadmin%3Dprefers%26ap%3Dx64-stable-statsdef_1%26brand%3DVDKB%26installdataindex%3Dempty/update2/installers/ChromeSetup.exe";
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = uri;
                System.Diagnostics.Process.Start(psi);
                Thread.Sleep(100);
            }
            if (checkBox2.Checked)
            {
                var uri = "https://dl.discordapp.net/distro/app/stable/win/x86/1.0.9012/DiscordSetup.exe";
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = uri;
                System.Diagnostics.Process.Start(psi);
                Thread.Sleep(100);
            }
            if (checkBox3.Checked)
            {
                // Steam
                var uri = "https://cdn.cloudflare.steamstatic.com/client/installer/SteamSetup.exe";
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = uri;
                System.Diagnostics.Process.Start(psi);
                Thread.Sleep(100);
            }
            if (checkBox4.Checked)
            {
                // Notepad++
                var uri = "https://github.com/notepad-plus-plus/notepad-plus-plus/releases/download/v8.5.2/npp.8.5.2.Installer.x64.exe";
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = uri;
                System.Diagnostics.Process.Start(psi);
                Thread.Sleep(100);
            }
            if (checkBox5.Checked)
            {
                // Battle.net
                var uri = "https://www.battle.net/download/getInstallerForGame?os=win&gameProgram=BATTLENET_APP&version=Live&id=1291358105.1681401064&_gl=1*1hf6kym*_ga*MTI5MTM1ODEwNS4xNjgxNDAxMDY0*_ga_VYKNV7C0S3*MTY4MTQwMTA2NC4xLjAuMTY4MTQwMTA2NC42MC4wLjA.";
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = uri;
                System.Diagnostics.Process.Start(psi);
                Thread.Sleep(100);
            }
            if (checkBox6.Checked)
            {
                // Github Desktop
                var uri = "https://central.github.com/deployments/desktop/desktop/latest/win32";
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = uri;
                System.Diagnostics.Process.Start(psi);
                Thread.Sleep(100);
            }
            if (checkBox7.Checked)
            {
                // Visual Studio 2022
                var uri = "https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022&source=VSLandingPage&cid=2030&passive=false";
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = uri;
                System.Diagnostics.Process.Start(psi);
                Thread.Sleep(100);
            }
            if (checkBox8.Checked)
            {
                // 7zip
                var uri = "https://www.7-zip.org/a/7z2201-x64.exe";
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = uri;
                System.Diagnostics.Process.Start(psi);
                Thread.Sleep(100);
            }
            if (checkBox9.Checked)
            {
                // Visual Studio Code
                var uri = "https://az764295.vo.msecnd.net/stable/704ed70d4fd1c6bd6342c436f1ede30d1cff4710/VSCodeUserSetup-x64-1.77.3.exe";
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = uri;
                System.Diagnostics.Process.Start(psi);
                Thread.Sleep(100);
            }
            if (checkBox10.Checked)
            {
                // EA Launcher
                var uri = "https://origin-a.akamaihd.net/EA-Desktop-Client-Download/installer-releases/EAappInstaller.exe";
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = uri;
                System.Diagnostics.Process.Start(psi);
                Thread.Sleep(100);
            }
            if (checkBox11.Checked)
            {
                // Uplay Launcher
                var uri = "https://static3.cdn.ubi.com/orbit/launcher_installer/UbisoftConnectInstaller.exe";
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = uri;
                System.Diagnostics.Process.Start(psi);
                Thread.Sleep(100);
            }
            if (checkBox12.Checked)
            {
                // Modded Spotify
                var uri = "https://github.com/amd64fox/SpotX/releases/download/1.7/Install_Auto.bat";
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = uri;
                System.Diagnostics.Process.Start(psi);
                Thread.Sleep(100);
                // MessageBox.Show("just run the Install_Auto File <3");

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

                System.Diagnostics.Process.Start("Install_Auto.bat");
            }
            if (checkBox13.Checked)
            {
                var uri = "https://drivers.amd.com/drivers/installer/22.40/whql/amd-software-adrenalin-edition-23.4.1-minimalsetup-230405_web.exe";
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = uri;
                System.Diagnostics.Process.Start(psi);
                Thread.Sleep(100);

            }
            if (checkBox14.Checked)
            {
                // NVIDIA GPU Driver
                var uri = "https://us.download.nvidia.com/GFE/GFEClient/3.27.0.112/GeForce_Experience_v3.27.0.112.exe";
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = uri;
                System.Diagnostics.Process.Start(psi);
                Thread.Sleep(100);
            }
            if (checkBox15.Checked)
            {
                MessageBox.Show("this button is disabled :(");
            }
            if (checkBox16.Checked)
            {
                // Super F4
                var uri = "https://github.com/stefansundin/superf4/releases/download/v1.4/SuperF4-1.4.exe";
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = uri;
                System.Diagnostics.Process.Start(psi);
                Thread.Sleep(100);
            }
            if (checkBox17.Checked)
            {
                // AutoHotKey
                var uri = "https://www.autohotkey.com/download/ahk-install.exe";
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = uri;
                System.Diagnostics.Process.Start(psi);
                Thread.Sleep(100);
            }
            if (checkBox18.Checked)
            {
                // AutoHotKey v2
                var uri = "https://www.autohotkey.com/download/ahk-v2.exe";
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = uri;
                System.Diagnostics.Process.Start(psi);
                Thread.Sleep(100);
            }
            if (checkBox19.Checked)
            {
                // Python
                var uri = "https://www.python.org/ftp/python/3.11.3/python-3.11.3-amd64.exe";
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = uri;
                System.Diagnostics.Process.Start(psi);
                Thread.Sleep(100);
            }
            if (checkBox20.Checked)
            {
                // Minecraft Old
                var uri = "https://aka.ms/minecraftClientWindows";
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = uri;
                System.Diagnostics.Process.Start(psi);
                Thread.Sleep(100);
            }
            if (checkBox21.Checked)
            {
                // Minecraft New
                var uri = "https://aka.ms/minecraftClientGameCoreWindows";
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = uri;
                System.Diagnostics.Process.Start(psi);
                Thread.Sleep(100);
            }
            if (checkBox22.Checked)
            {
                // Epic Games
                var uri = "https://launcher-public-service-prod06.ol.epicgames.com/launcher/api/installer/download/EpicGamesLauncherInstaller.msi";
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = uri;
                System.Diagnostics.Process.Start(psi);
                Thread.Sleep(100);
            }
            if (checkBox23.Checked)
            {
                // Process Killer
                var uri = "https://github.com/Spinchies/Process-Killer/releases/download/Process-Killer/ProcessKiller.exe";
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = uri;
                System.Diagnostics.Process.Start(psi);
                Thread.Sleep(100);
            }
            if (checkBox24.Checked)
            {
                // Windows Terminal
                var uri = "https://github.com/microsoft/terminal/releases/download/v1.16.10261.0/Microsoft.WindowsTerminal_Win10_1.16.10261.0_8wekyb3d8bbwe.msixbundle";
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = uri;
                System.Diagnostics.Process.Start(psi);
                Thread.Sleep(100);
            }
            if (checkBox25.Checked)
            {
                // Rufus
                var uri = "https://github.com/pbatard/rufus/releases/download/v3.22/rufus-3.22.exe";
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = uri;
                System.Diagnostics.Process.Start(psi);
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
                    var uri = "https://rzr.to/synapse-3-pc-download";
                    var psi = new System.Diagnostics.ProcessStartInfo();
                    psi.UseShellExecute = true;
                    psi.FileName = uri;
                    System.Diagnostics.Process.Start(psi);
                    Thread.Sleep(100);

                    var urx = "https://rzr.to/71-surround-sound-installer";
                    var psx = new System.Diagnostics.ProcessStartInfo();
                    psi.UseShellExecute = true;
                    psi.FileName = urx;
                    System.Diagnostics.Process.Start(psx);
                    Thread.Sleep(100);
                }
                else
                {
                    var uri = "https://rzr.to/synapse-3-pc-download";
                    var psi = new System.Diagnostics.ProcessStartInfo();
                    psi.UseShellExecute = true;
                    psi.FileName = uri;
                    System.Diagnostics.Process.Start(psi);
                    Thread.Sleep(100);
                }
                Thread.Sleep(100);
            }
            if (checkBox27.Checked)
            {
                // Corsair iCue
                var uri = "https://downloads.corsair.com/Files/CUE/iCUESetup_4.33.138_release.msi";
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = uri;
                System.Diagnostics.Process.Start(psi);
                Thread.Sleep(100);
            }
            if (checkBox28.Checked)
            {
                // qFlipper
                var uri = "https://update.flipperzero.one/builds/qFlipper/1.3.0/qFlipperSetup-64bit-1.3.0.exe";
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = uri;
                System.Diagnostics.Process.Start(psi);
                Thread.Sleep(100);
            }
            if (checkBox29.Checked)
            {
                // Iobit Unlocker
                var uri = "https://cdn.iobit.com/dl/unlocker-setup.exe";
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = uri;
                System.Diagnostics.Process.Start(psi);
                Thread.Sleep(100);
            }
            if (checkBox30.Checked)
            {
                // VCRedist AIO
                var uri = "https://github.com/abbodi1406/vcredist/releases/download/v0.70.0/VisualCppRedist_AIO_x86_x64_70.zip";
                var psi = new System.Diagnostics.ProcessStartInfo();
                psi.UseShellExecute = true;
                psi.FileName = uri;
                System.Diagnostics.Process.Start(psi);
                Thread.Sleep(100);
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

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}