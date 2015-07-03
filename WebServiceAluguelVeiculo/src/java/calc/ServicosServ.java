package calc;

import java.util.ArrayList;
import java.util.NoSuchElementException;
import javax.swing.JOptionPane;

/**
 *
 * @author Lucas
 */
public class ServicosServ {

    private static ServicosServ instancia;
    public static Veiculo [] listaVeiculo = new Veiculo[4];

    private ServicosServ(){
    }

    /**
     *
     * @return
     */
    public static Veiculo [] getListaVeiculo() {
        return listaVeiculo;
    }

    
    public void setListaVeiculo(Veiculo [] listaVeiculo) {
        ServicosServ.listaVeiculo = listaVeiculo;
    }

    /**
     *
     * @return
     */
    public static ServicosServ getInstancia() {
        if (instancia == null) {
            instancia = new ServicosServ();
        }
        return instancia;
    }

    
    public static void inserirVeiculos() {
//        listaVeiculo = null;
        
        Veiculo veiculo1 = new Veiculo("Uno", "Fiat", 2015, 200, false);
        listaVeiculo[0] = veiculo1;
        
        Veiculo veiculo2 = new Veiculo("Idea", "Fiat", 2015, 200, false);
        listaVeiculo[1] = veiculo2;
        
        Veiculo veiculo3 = new Veiculo("Doblo", "Fiat", 2015, 200, false);
        listaVeiculo[2] = veiculo3;
        
        Veiculo veiculo4 = new Veiculo("Siena", "Fiat", 2015, 200, false);
        listaVeiculo[3] = veiculo4;
        
        for(Veiculo veiculo: listaVeiculo){
            System.out.println(veiculo.toString());
        }
        
        //Serializa.serializaVeiculos(listaVeiculo);
        
        
//        Serializa serializa = new Serializa();
//        String msg = "Veículo cadastrado com sucesso!";
//        JOptionPane.showMessageDialog(null, msg);
//        serializa.descerializaVeiculos(serializa.serializaVeiculos(listaVeiculo));
        
    }
    
//     public void salvarVeiculo(Veiculo veiculo) {
//        listaVeiculo.add(veiculo);
//        Serializa serializa = new Serializa();
//        String msg = "Veículo cadastrado com sucesso!";
//        JOptionPane.showMessageDialog(null, msg);
//        serializa.descerializaVeiculos(serializa.serializaVeiculos(listaVeiculo));
//        
//    }

    
    public static void editarVeiculo(int indice, boolean reqCliente, Veiculo veiculo) {
        indice = indice - 1;
//        listaVeiculo.set(indice, veiculo);
//        if(!reqCliente){
//            String msg = "Veículo editado com sucesso!";
//            JOptionPane.showMessageDialog(null, msg);
//        }
//        
//        Serializa serializa = new Serializa();
//        serializa.serializaVeiculos(listaVeiculo);
            
//        int i = 0;
        
//        for (Interessado inter : ServImpl.listaInteressados) {
//            if (inter.getModeloVeic().equals(veiculo.getModelo())){
//                if(inter.getValor() >= veiculo.getValorLocacao()){
//                    ServImpl.notificarCarro(inter.getModeloVeic()/*, inter.getRefCli()*/);
//                    //ServImpl.listaInteressados.remove(i);
//                }
//            }
//            i++;
//        }
    }

    
//    public static Veiculo buscarVeiculo(String modeloVeiculo) {
//        Veiculo veiculo = null;
//        try {
//            veiculo = listaVeiculo.
//                    stream().
//                    filter(v -> (v.getModelo() == null ? modeloVeiculo == null
//                                    : v.getModelo().equals(modeloVeiculo))).
//                    findFirst().get();
//        } catch (NoSuchElementException e) {
//            String msg = "Veículo não cadastrado!";
//            JOptionPane.showMessageDialog(null, msg);
//        }
//
//        return veiculo;
//    }

}
