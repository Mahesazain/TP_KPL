namespace tpmodul4_1302220105
{
    internal class KodePos
    {
        private string[,] kodeposArray = new string[,]
        {
            { "batununggal", "40266" },
            { "kujangsari", "40287" },
            { "mengger", "40267" },
            { "wates", "40256" },
            { "cijaura", "40287" },
            { "jatisari", "40286" },
            { "margasari", "40286" },
            { "sekejati", "40286" },
            { "kebonwaru", "40272" },
            { "maleer", "40274" },
            { "samoja", "40273" }
        };

        public string GetKodepos(string kelurahan)
        {
            for (int i = 0; i < kodeposArray.GetLength(0); i++)
            {
                if (kodeposArray[i, 0].ToLower() == kelurahan.ToLower())
                {
                    return kodeposArray[i, 1];
                }
            }
            return "Kelurahan tidak ditemukan.";
        }
    }
}
