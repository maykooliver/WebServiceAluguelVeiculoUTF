package calc;

import javax.xml.ws.Endpoint;
 
public class ServerPublisher {
 
    public static void main(String[] args)
    {
        Endpoint.publish("http://127.0.0.1:9876/calc",
        new ServImpl());
    }
}