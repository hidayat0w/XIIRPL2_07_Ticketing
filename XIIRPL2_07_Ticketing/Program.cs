using XIIRPL2_07_Ticketing.MasterForm;

namespace XIIRPL2_07_Ticketing
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //FrmLogin FrmLogin = new FrmLogin();
            //FrmLogin.Show();
            //FrmMasterBandara bandara = new FrmMasterBandara();
            //bandara.Show();
            //FrmMasterMaskapai maskapai = new FrmMasterMaskapai();
            //maskapai.Show();
            //FrmMasterKodePromo kodePromo = new FrmMasterKodePromo();
            //kodePromo.Show();
            FrmMasterJadwalPenerbangan jadwalPenerbangan = new FrmMasterJadwalPenerbangan();
            jadwalPenerbangan.Show();

            Application.Run();
        }
    }
}