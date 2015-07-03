package calc;
import java.util.ArrayList;
import javax.jws.WebMethod;
import javax.jws.WebService;
import javax.jws.soap.SOAPBinding;

/**
 *
 * @author Lucas
 */
@WebService
@SOAPBinding(style = SOAPBinding.Style.RPC)
public interface InterfaceServ{
    
    /**
     * Devolver Veículo.
     * Realiza a solicitação para a devolução de um veículo.
     * @param nomeCli
     * @param ref
     * @return 
     * @throws java.rmi.RemoteException
     */
    @WebMethod public boolean devolverVeiculo(String nomeCli/*, InterfaceCli ref*/);

    /**
     * Alugar Veículo.
     * @param modeloVeiculoLocado
     * @param locRetirada
     * @param locDevolucao
     * @param dataIni
     * @param horaInicio
     * @param dataTerm
     * @param horaFim
     * @param condutor
     * @param idade
     * @param numeroParcelas
     * @param ref
     * @return 
     * @throws java.rmi.RemoteException 
     */
    @WebMethod public boolean alugarVeic(String modeloVeiculoLocado, String locRetirada, String locDevolucao, String dataIni, String horaInicio, String dataTerm, String horaFim, String condutor, int idade, String numeroParcelas/*, InterfaceCli ref*/);

    /**
     * Registrar Interesse de Veículo.
     * @param modeloVeic
     * @param valor
     * @param ref
     * @return 
     * @throws java.rmi.RemoteException 
     */
    @WebMethod public boolean regInteresseVeic(String modeloVeic, float valor/*, InterfaceCli ref*/);

    /**
     * Solicitar Formulário de Locação.
     * @param modeloVeic
     * @param ref
     * @return 
     * @throws java.rmi.RemoteException 
     */
    @WebMethod public boolean solicitacaoFormLocacao(String modeloVeic/*, InterfaceCli ref*/);

    /**
     * Novo Cliente Conectado.
     * Informa que um novo cliente se conectou ao servidor.
     * @param nomeCli 
     * @throws java.rmi.RemoteException 
     */
    @WebMethod public void novoClienteConectado(String nomeCli);
    
    /**
     *
     * @return
     * @throws RemoteException
     */
    @WebMethod public String[] consultarVeiculos();
    
}
