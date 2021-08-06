namespace N2_POO2BIM.Interfaces
{
    interface IAviao
    {
        bool Voando { get; }

        string Decolar();
        string Arremeter();
        string Pousar();
    }
}
