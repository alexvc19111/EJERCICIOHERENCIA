class servicio:empleados
{
    public string seccion{get;set;}
    public servicio(string nombre,string apellidos, int id,string estadocivil, int añoincorp,int numerodesp,string seccion):base(nombre,apellidos,id,estadocivil,añoincorp,numerodesp)
    {
        this.seccion=seccion;
    }
     public void cambioseccion()
    {
        string nuevasec="Secretaría";
        Console.WriteLine("Se ha cambiado de la sección "+seccion+" a la sección  "+nuevasec+" al empleado del personal de servicio");
        seccion=nuevasec; 
    }
    public void imprimir()
    {
        Console.WriteLine("Personal de Servicio:");
        Console.WriteLine("|Nombre: "+nombre+"||Apellidos: "+apellidos+"||ID: "+id+"||Estado Civil: "+estadocivil+"||Año de incorporación: "+añoincorp+"||Número de despacho: "+numerodesp+"||Seccion designada"+seccion);
    }
    
}