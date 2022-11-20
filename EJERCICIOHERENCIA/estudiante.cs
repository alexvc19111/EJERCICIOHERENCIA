class estudiante:persona
{
    public string curso{get;set;}
    public estudiante (string nombre,string apellidos, int id,string estadocivil,string curso):base(nombre,apellidos,id,estadocivil)
    {
        this.curso=curso;
    }
    public void matricula()
    {
        string nuevocurso="Matematicas 3";
        Console.WriteLine("El estudiante a sido matriculado en un nuevo curso :"+nuevocurso);
        curso=curso+nuevocurso;
    }
    public void imprimir()
    {
        Console.WriteLine("Estudiante:");
        Console.WriteLine("|Nombre: "+nombre+"||Apellidos: "+apellidos+"||ID: "+id+"||Estado Civil: "+estadocivil+"||Curso: "+curso);
    }
}