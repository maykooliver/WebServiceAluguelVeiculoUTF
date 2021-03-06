package calc;


/**
 *
 * @author Lucas
 */
public class Veiculo implements java.io.Serializable{
    private String modelo;
    private String marca;
    private int ano;
    private double valorLocacao;
    private boolean ocupado;
    
    public Veiculo() {
    
    } 

    public Veiculo(String modelo, String marca, int ano, double valorLocacao, boolean ocupado) {
        this.modelo = modelo;
        this.marca = marca;
        this.ano = ano;
        this.valorLocacao = valorLocacao;
        this.ocupado = ocupado;
    }

    @Override
    public String toString() {
        return "Veiculo{" + "modelo=" + modelo + ", marca=" + marca + ", ano=" + ano + ", valorLocacao=" + valorLocacao + ", ocupado=" + ocupado + '}';
    }
    
    

    
    /**
     * @return the modelo
     */
    public String getModelo() {
        return modelo;
    }

    /**
     * @param modelo the modelo to set
     */
    public void setModelo(String modelo) {
        this.modelo = modelo;
    }

    /**
     * @return the marca
     */
    public String getMarca() {
        return marca;
    }

    /**
     * @param marca the marca to set
     */
    public void setMarca(String marca) {
        this.marca = marca;
    }

    /**
     * @return the ano
     */
    public int getAno() {
        return ano;
    }

    /**
     * @param ano the ano to set
     */
    public void setAno(int ano) {
        this.ano = ano;
    }

    /**
     * @return the valorLocacao
     */
    public double getValorLocacao() {
        return valorLocacao;
    }

    /**
     * @param valorLocacao the valorLocacao to set
     */
    public void setValorLocacao(double valorLocacao) {
        this.valorLocacao = valorLocacao;
    }

    /**
     * @return the ocupado
     */
    public boolean isOcupado() {
        return ocupado;
    }

    /**
     * @param ocupado the ocupado to set
     */
    public void setOcupado(boolean ocupado) {
        this.ocupado = ocupado;
    }
    
}
