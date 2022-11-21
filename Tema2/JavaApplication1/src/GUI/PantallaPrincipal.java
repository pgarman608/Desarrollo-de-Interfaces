package GUI;

import Datos.Cliente;
import logica.logicaNegocio;
import java.util.ArrayList;
import java.util.List;
import javax.swing.RowFilter;
import javax.swing.RowSorter;
import javax.swing.RowSorter.SortKey;
import javax.swing.SortOrder;
import javax.swing.table.DefaultTableModel;
import javax.swing.table.TableModel;
import javax.swing.table.TableRowSorter;

public class PantallaPrincipal extends javax.swing.JFrame {

    public PantallaPrincipal() {
        initComponents();
        refrescarTabla();
    }

    private void refrescarTabla() {
        DefaultTableModel dtm=new DefaultTableModel();
        dtm.setColumnIdentifiers(new String[]{"nombre","Apellidos","Fecha Alta","Provincia"});
        List<Cliente> listaClientes=logicaNegocio.getListaClientes();
        for (Cliente cliente:listaClientes){
            dtm.addRow(cliente.toArrayString());
        }
        jTableClientes.setModel(dtm);
        TableRowSorter<TableModel> sorter=new TableRowSorter<>(dtm);
        jTableClientes.setRowSorter(sorter);
        List<RowSorter.SortKey> claves =new ArrayList<RowSorter.SortKey>();
        claves.add(new SortKey(1,SortOrder.ASCENDING));
        claves.add(new SortKey(0,SortOrder.ASCENDING));
        claves.add(new SortKey(2,SortOrder.ASCENDING));
        claves.add(new SortKey(3,SortOrder.ASCENDING));
        sorter.setSortKeys(claves);
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jScrollPane1 = new javax.swing.JScrollPane();
        jTableClientes = new javax.swing.JTable();
        jbtFiltrar = new javax.swing.JButton();
        jtfFiltrar = new javax.swing.JTextField();
        jMenuBar1 = new javax.swing.JMenuBar();
        jMenu1 = new javax.swing.JMenu();
        jMenuItemAlta = new javax.swing.JMenuItem();
        jMenuSalir = new javax.swing.JMenu();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jTableClientes.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null}
            },
            new String [] {
                "Nombre", "Apellidos", "Fecha Alta", "Provincia"
            }
        ) {
            boolean[] canEdit = new boolean [] {
                false, false, true, false
            };

            public boolean isCellEditable(int rowIndex, int columnIndex) {
                return canEdit [columnIndex];
            }
        });
        jScrollPane1.setViewportView(jTableClientes);

        jbtFiltrar.setText("Filtrar");
        jbtFiltrar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jbtFiltrarActionPerformed(evt);
            }
        });

        jMenu1.setText("Clientes");

        jMenuItemAlta.setText("Alta ...");
        jMenuItemAlta.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jMenuItemAltaActionPerformed(evt);
            }
        });
        jMenu1.add(jMenuItemAlta);

        jMenuBar1.add(jMenu1);

        jMenuSalir.setText("Salir");
        jMenuSalir.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jMenuSalirMouseClicked(evt);
            }
        });
        jMenuBar1.add(jMenuSalir);

        setJMenuBar(jMenuBar1);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 375, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addComponent(jtfFiltrar, javax.swing.GroupLayout.PREFERRED_SIZE, 148, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addComponent(jbtFiltrar)
                .addContainerGap(363, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap(52, Short.MAX_VALUE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(25, 25, 25)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jtfFiltrar, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jbtFiltrar)))
                    .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 219, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(66, 66, 66))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jMenuItemAltaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jMenuItemAltaActionPerformed
        dialogoAlta dialogo=new dialogoAlta(this,true);
        dialogo.setVisible(true);
        refrescarTabla();
    }//GEN-LAST:event_jMenuItemAltaActionPerformed

    private void jMenuSalirMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jMenuSalirMouseClicked
        dispose();
    }//GEN-LAST:event_jMenuSalirMouseClicked

    private void jbtFiltrarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jbtFiltrarActionPerformed
        DefaultTableModel modeloTabla = (DefaultTableModel)jTableClientes.getModel();
        TableRowSorter<DefaultTableModel> filtro = new TableRowSorter<>(modeloTabla);
        jTableClientes.setRowSorter(filtro);
        filtro.setRowFilter(RowFilter.regexFilter(this.jtfFiltrar.getText()));
    }//GEN-LAST:event_jbtFiltrarActionPerformed

    public static void main(String args[]) {
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new PantallaPrincipal().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JMenu jMenu1;
    private javax.swing.JMenuBar jMenuBar1;
    private javax.swing.JMenuItem jMenuItemAlta;
    private javax.swing.JMenu jMenuSalir;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTable jTableClientes;
    private javax.swing.JButton jbtFiltrar;
    private javax.swing.JTextField jtfFiltrar;
    // End of variables declaration//GEN-END:variables
}
