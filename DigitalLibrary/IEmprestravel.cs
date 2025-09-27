namespace DigitalLibrary;

internal interface IEmprestravel
{

    public void Emprestar();
    public void Devolver();

    bool EstaEmprestado {  get; }
}
