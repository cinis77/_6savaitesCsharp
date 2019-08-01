namespace _20190801_vartotojai
{
    internal class Vartotojas
    {
        public int Id { get; }
        public string VartotojoVardas { get; }
        private string Slaptazodis;

        public Vartotojas(string vartotojoVardas, string Slaptazodis)
        {
            VartotojoVardas = vartotojoVardas;
            this.Slaptazodis = Slaptazodis;
        }

        public bool Prisijungti(string loginName, string psw)
        {
            if (loginName == VartotojoVardas && Slaptazodis == psw)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}