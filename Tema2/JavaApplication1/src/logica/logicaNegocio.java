package logica;

import Datos.Cliente;
import java.util.ArrayList;
import java.util.List;

public class logicaNegocio {
   
    private static List<Cliente> listaClientes=new ArrayList<>();
      
    public static void  anadirCliente (Cliente cliente){
        listaClientes.add(cliente);
    }

    public static List<Cliente> getListaClientes() {
        return listaClientes;
    }
}
