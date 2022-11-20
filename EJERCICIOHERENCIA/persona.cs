class persona
{
    public string nombre{get;set;}
    public string apellidos{get;set;}
    public int id{get;set;}
    public string estadocivil{get;set;}
    public persona(string nombre,string apellidos, int id,string estadocivil)
    {
        this.nombre=nombre;
        this.apellidos=apellidos;
        this.id=id;
        this.estadocivil=estadocivil;
    }
    public void cambioestado()
    {
        if(estadocivil=="Soltero")
        {
            estadocivil="Casado";
        }
        else
        {
            estadocivil="Divorciado";
        }
        if (estadocivil=="Divordciado")
        {
            estadocivil="Casado";
        }
        Console.WriteLine("El estado civil de "+nombre+" "+apellidos+" ha sido cambiado a "+estadocivil);
    }

}