using System;
class Program {


public class Libro{
    int correlativo = 1;
     string nombre;
      int codigo;
      int CantPaginas;
      int PagLeidas;
      int estado;
      int leer;
      bool leido;

public Libro(string nombre, int cantidadPaginas) {
        this.codigo = correlativo;
        this.nombre = nombre;
        this.CantPaginas = cantidadPaginas;
        this.PagLeidas = 0;
        this.leido = false;
        correlativo++;

}
public void leerlibrodiario (int paginas){
    if (PagLeidas + paginas > CantPaginas){
        Console.WriteLine("Para un rato no se puede seguir leyendo ");

    }else {
            PagLeidas += paginas;
            Console.WriteLine("Páginas leídas: " + PagLeidas);
            if (PagLeidas == CantPaginas) {
                leido = true;
                Console.WriteLine("¡El libro ha sido completado!");
              }
        }

    }




    public float ObtenerPorcentajeLectura() {
        return (float)PagLeidas / CantPaginas * 100;
    }

    public int ObtenerPaginaActual() {
        return PagLeidas + 1;
    }

    public void MostrarLibro() {
        Console.WriteLine("Código de libro: " + codigo);
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Cantidad de páginas: " + CantPaginas);
        Console.WriteLine("Porcentaje de lectura: " + ObtenerPorcentajeLectura() + "%");
        Console.WriteLine("Páginas leídas: " + PagLeidas);
        Console.WriteLine("Estado: " + ObtenerEstadoLibro());
    }

    public string ObtenerEstadoLibro() {
        if (leido) {
            return "Leído";
        } else if (PagLeidas > 0) {
            return "En proceso";
        } else {
            return "No leído";
        }
    }
}
    static void Main(string[] args) {
        Libro libro1 = new Libro("La Odisea", 352);
        libro1.MostrarLibro();

        Console.WriteLine();

        libro1.leerlibrodiario(50);
        libro1.leerlibrodiario(100);
        libro1.MostrarLibro();

        Console.WriteLine();

        libro1.leerlibrodiario(250);
        libro1.MostrarLibro();
    }
}












   





