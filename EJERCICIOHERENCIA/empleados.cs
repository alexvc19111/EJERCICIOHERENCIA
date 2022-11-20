class empleados:persona
{

    public int añoincorp{get;set;}
    public int numerodesp{get;set;}
    public empleados(string nombre,string apellidos, int id,string estadocivil, int añoincorp,int numerodesp):base(nombre,apellidos,id,estadocivil)
    {
        this.añoincorp=añoincorp;
        this.numerodesp=numerodesp;
    }
    public void reasignaciondesp()
    {
        int nuevodesp=123;
        numerodesp=nuevodesp;
        Console.WriteLine("Se ha reasignado al despacho :"+nuevodesp+" al empleado "+nombre+" "+apellidos);
    }
}