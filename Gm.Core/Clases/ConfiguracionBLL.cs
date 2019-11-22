namespace Gm.Core
{
    public class ConfiguracionBLL
    {
        public int x;
        public int y=5;
        public ConfiguracionBLL(int Width, int anchoInterno)
        {
            //Obtenemos el anto actual y lo divimos en la mitad
            int ancho = Width / 2;
            x = ancho - (anchoInterno / 2);
        }
    }
}
