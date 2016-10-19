/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Clases;

import GUI.GUI_Demostracion;
import java.util.ArrayList;

/**
 *
 * @author wsulivan
 */
public class SolucionRecursiva {
    GUI_Demostracion demo = new GUI_Demostracion();
    ArrayList<String> vector;
    int count=1;
    /**
     *
     */
    public SolucionRecursiva() {
        this.vector = new ArrayList<String>();
    }
    /**
     *
     * @param discos
     * @param torreA
     * @param torreB
     * @param torreC
     */
    public void  solucionRecursivas(int discos, String torreA, String torreB, String torreC) {        
        if (discos == 1) {            
            String mensaje = (count+". Moviendo Disco a Torre " + torreA + " hacia la Torre " + torreC+"\n");
            vector.add(mensaje);
            count++;
            //System.out.println("Moviendo Disco a Torre "+torreA+" hacia la Torre "+torreC);
        } else {
            solucionRecursivas(discos - 1, torreA, torreC, torreB);
            String mensaje = (count+". Moviendo Disco a Torre " + torreA + " hacia la Torre " + torreC+"\n" );
            vector.add(mensaje);
            //System.out.println("Moviendo Disco a Torre "+torreA+" hacia la Torre "+torreC);
            solucionRecursivas(discos - 1, torreB, torreA, torreC);
            count++;
        }
    }
    /**
     *
     * @param discos
     */
    public void solicitaDatos(int discos) {
        String torreA = "Torre A";
        String torreB = "Torre B";
        String torreC = "Torre C";
        solucionRecursivas(discos, torreA, torreB, torreC);
    }
    /**
     *
     * @return
     */
    public String  concatenaImpresion() {
        String mensaje=vector.toString();
        System.out.println(mensaje);
        return mensaje;  
    }
}

