namespace primeiropoo
{
    public class Personagem
    {
    
    public string none;
    public int idade;
    public string armadura;
        internal string nome;

        public float Atacar(float forca , float potencia)
    {
        return forca + potencia;
    }

    public string Defender()
    {
        return "o personagem atacou!";
    }
    
    
