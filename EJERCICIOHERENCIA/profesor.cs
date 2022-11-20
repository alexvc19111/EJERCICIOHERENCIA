class profesor:empleados
{
    public string departamento{get;set;}
    public profesor(string nombre,string apellidos, int id,string estadocivil, int añoincorp,int numerodesp,string departamento):base(nombre,apellidos,id,estadocivil,añoincorp,numerodesp)
    {
        this.departamento=departamento;
    }
    public void cambiodepartamento()
    {
        string nuevodep="Lenguaje";
        Console.WriteLine("Se ha cambiado del departamento de "+departamento+" al departamento de "+nuevodep+" al profesor");
        departamento=nuevodep;
        
    }
    public void imprimir()
    {
        Console.WriteLine("Profesor:");
        Console.WriteLine("|Nombre: "+nombre+"||Apellidos: "+apellidos+"||ID: "+id+"||Estado Civil: "+estadocivil+"||Año de incorporación: "+añoincorp+"||Número de despacho: "+numerodesp+"||Departamento: "+departamento);
    }

}