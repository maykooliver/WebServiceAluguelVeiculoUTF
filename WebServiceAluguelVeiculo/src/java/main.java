
import javax.xml.ws.Endpoint;

    /*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Mayko
 */
public class main {
    public static void main(String[] args)
    {
        Endpoint.publish("http://127.0.0.1:9876/calc",
        new CalculadoraServerImpl());
    }
    
}
