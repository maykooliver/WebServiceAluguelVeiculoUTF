package aluguelveiculosutf.view;

import aluguelveiculosutf.servidor.ServicosServ;
import aluguelveiculosutf.servidor.Veiculo;
import aluguelveiculosutf.util.MyNumber;

/**
 *
 * @author Mayko
 */
public class CadastrarVeiculoView extends javax.swing.JDialog {
    
    int id = 0;
    
    Veiculo veiculo = new Veiculo();

    /**
     * Creates new form LocacaoVeiculo
     * @param parent
     * @param modal
     */
    public CadastrarVeiculoView(java.awt.Frame parent, boolean modal) {
        super(parent, modal);
        initComponents();
        this.setLocationRelativeTo(null);
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jLabel3 = new javax.swing.JLabel();
        jTextField2 = new javax.swing.JTextField();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        jtfModelo = new javax.swing.JTextField();
        jLabel4 = new javax.swing.JLabel();
        jtfMarca = new javax.swing.JTextField();
        jLabel5 = new javax.swing.JLabel();
        jtfAno = new javax.swing.JTextField();
        jLabel6 = new javax.swing.JLabel();
        jtfValorLocacao = new javax.swing.JTextField();
        cadastrarVeiculo = new javax.swing.JButton();
        atualizarVeiculo = new javax.swing.JButton();
        buscarVeiculo = new javax.swing.JButton();

        jLabel3.setText("Modelo");

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);

        jLabel1.setText("Cadastro de Veículo:");

        jLabel2.setText("Modelo");

        jLabel4.setText("Marca");

        jLabel5.setText("Ano");

        jLabel6.setText("Valor Locação");

        cadastrarVeiculo.setText("Cadastrar");
        cadastrarVeiculo.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                cadastrarVeiculoActionPerformed(evt);
            }
        });

        atualizarVeiculo.setText("Atualizar");
        atualizarVeiculo.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                atualizarVeiculoActionPerformed(evt);
            }
        });

        buscarVeiculo.setText("Buscar");
        buscarVeiculo.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                buscarVeiculoActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(21, 21, 21)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(cadastrarVeiculo)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(atualizarVeiculo)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(buscarVeiculo))
                    .addComponent(jLabel6)
                    .addComponent(jLabel5)
                    .addComponent(jLabel4)
                    .addComponent(jLabel1)
                    .addComponent(jLabel2)
                    .addComponent(jtfValorLocacao)
                    .addComponent(jtfAno)
                    .addComponent(jtfMarca)
                    .addComponent(jtfModelo))
                .addContainerGap(20, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jLabel1)
                .addGap(23, 23, 23)
                .addComponent(jLabel2)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jtfModelo, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addComponent(jLabel4)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jtfMarca, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jLabel5)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jtfAno, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(jLabel6)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jtfValorLocacao, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 32, Short.MAX_VALUE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(cadastrarVeiculo)
                    .addComponent(atualizarVeiculo)
                    .addComponent(buscarVeiculo))
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void cadastrarVeiculoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_cadastrarVeiculoActionPerformed
        
        ServicosServ servico = ServicosServ.getInstancia();
        
        
        veiculo.setModelo(jtfModelo.getText());
        veiculo.setMarca(jtfMarca.getText());
        veiculo.setAno(Integer.parseInt(jtfAno.getText()));
        veiculo.setValorLocacao(Double.parseDouble(jtfValorLocacao.getText()));
        
        System.out.println(veiculo.toString());
        
        servico.salvarVeiculo(veiculo);
        
        
        
        limparTela();        
        
        dispose();
    }//GEN-LAST:event_cadastrarVeiculoActionPerformed

    public void limparTela(){
        jtfModelo.setText("");
        jtfMarca.setText("");
        jtfAno.setText("");
        jtfValorLocacao.setText("");
    }
    
    private void atualizarVeiculoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_atualizarVeiculoActionPerformed
        
        ServicosServ servico = ServicosServ.getInstancia();
        
        veiculo.setModelo(jtfModelo.getText());
        veiculo.setMarca(jtfMarca.getText());
        veiculo.setAno(Integer.parseInt(jtfAno.getText()));
        veiculo.setValorLocacao(Double.parseDouble(jtfValorLocacao.getText()));
        
        //System.out.println(veiculo.toString());
        
        servico.editarVeiculo(id, false, veiculo);
        
        limparTela();
        
        dispose();
        
    }//GEN-LAST:event_atualizarVeiculoActionPerformed

    private void buscarVeiculoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_buscarVeiculoActionPerformed
        BuscaVeiculoView buscaVeiculos = new BuscaVeiculoView(null, true);
        buscaVeiculos.setVisible(true);
        
        id = buscaVeiculos.getId();
        
        veiculo = buscaVeiculos.getVeiculo();
        //System.out.println(veiculo.toString());
        if (veiculo != null){
            jtfModelo.setEnabled(false);
            jtfMarca.setEnabled(false);        
            jtfAno.setEnabled(false);
            
            jtfModelo.setText(MyNumber.parseString(veiculo.getModelo()));
            jtfMarca.setText(MyNumber.parseString(veiculo.getMarca()));
            jtfAno.setText(MyNumber.parseString(veiculo.getAno()));
            jtfValorLocacao.setText(MyNumber.parseString(veiculo.getValorLocacao()));
        }
    }//GEN-LAST:event_buscarVeiculoActionPerformed

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(CadastrarVeiculoView.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(CadastrarVeiculoView.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(CadastrarVeiculoView.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(CadastrarVeiculoView.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>
        //</editor-fold>

        /* Create and display the dialog */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                CadastrarVeiculoView dialog = new CadastrarVeiculoView(new javax.swing.JFrame(), true);
                dialog.addWindowListener(new java.awt.event.WindowAdapter() {
                    @Override
                    public void windowClosing(java.awt.event.WindowEvent e) {
                        System.exit(0);
                    }
                });
                dialog.setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton atualizarVeiculo;
    private javax.swing.JButton buscarVeiculo;
    private javax.swing.JButton cadastrarVeiculo;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JTextField jTextField2;
    private javax.swing.JTextField jtfAno;
    private javax.swing.JTextField jtfMarca;
    private javax.swing.JTextField jtfModelo;
    private javax.swing.JTextField jtfValorLocacao;
    // End of variables declaration//GEN-END:variables
}