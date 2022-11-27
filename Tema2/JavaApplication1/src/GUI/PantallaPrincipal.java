package GUI;

import Datos.Cliente;
import java.awt.event.MouseEvent;
import logica.logicaNegocio;
import java.util.List;
import javax.swing.JOptionPane;
import javax.swing.RowFilter;
import javax.swing.table.DefaultTableModel;
import javax.swing.table.TableRowSorter;

public class PantallaPrincipal extends javax.swing.JFrame {
    private int valorTabla = -1;
    private DefaultTableModel dtm;
    
    public PantallaPrincipal() {
        initComponents();
        dtm = (DefaultTableModel) jTableClientes.getModel();
        refrescarTabla();
        this.jTableClientes.addMouseListener(new java.awt.event.MouseAdapter() {
            @Override
            public void mouseClicked(MouseEvent evt) {
                valorTabla = jTableClientes.rowAtPoint(evt.getPoint());
            }

            @Override
            public void mouseReleased(MouseEvent e) {
                valorTabla = -1;
            }
        });
    }

    private void refrescarTabla(){
        dtm.setNumRows(0);
        List<Cliente> listaClientes=logicaNegocio.getListaClientes();
        for (Cliente cliente:listaClientes){
            dtm.addRow(cliente.toArrayString());
        }
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jScrollPane1 = new javax.swing.JScrollPane();
        jTableClientes = new javax.swing.JTable();
        jbtFiltrar = new javax.swing.JButton();
        jtfFiltrar = new javax.swing.JTextField();
        jbtnAniadir = new javax.swing.JButton();
        btnEliminar = new javax.swing.JButton();
        btnEditar = new javax.swing.JButton();
        jMenuBar1 = new javax.swing.JMenuBar();
        jMenu1 = new javax.swing.JMenu();
        jMenuItemAlta = new javax.swing.JMenuItem();
        jMenuSalir = new javax.swing.JMenu();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jTableClientes.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {

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

        jbtnAniadir.setText("Añadir");
        jbtnAniadir.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jbtnAniadirActionPerformed(evt);
            }
        });

        btnEliminar.setText("Eliminar");
        btnEliminar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnEliminarActionPerformed(evt);
            }
        });

        btnEditar.setText("Editar");
        btnEditar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnEditarActionPerformed(evt);
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
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jtfFiltrar, javax.swing.GroupLayout.PREFERRED_SIZE, 148, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(18, 18, 18)
                        .addComponent(jbtFiltrar))
                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                        .addComponent(jbtnAniadir, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(btnEditar, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(btnEliminar, javax.swing.GroupLayout.Alignment.LEADING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)))
                .addContainerGap(363, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap(75, Short.MAX_VALUE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jbtnAniadir)
                        .addGap(18, 18, 18)
                        .addComponent(btnEliminar)
                        .addGap(18, 18, 18)
                        .addComponent(btnEditar)
                        .addGap(18, 18, 18)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jtfFiltrar, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jbtFiltrar)))
                    .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 219, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(66, 66, 66))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jbtFiltrarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jbtFiltrarActionPerformed
        dtm = (DefaultTableModel)jTableClientes.getModel();
        TableRowSorter<DefaultTableModel> filtro = new TableRowSorter<>(dtm);
        jTableClientes.setRowSorter(filtro);
        filtro.setRowFilter(RowFilter.regexFilter(this.jtfFiltrar.getText()));
    }//GEN-LAST:event_jbtFiltrarActionPerformed

    private void jMenuSalirMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jMenuSalirMouseClicked
        dispose();
    }//GEN-LAST:event_jMenuSalirMouseClicked

    private void jMenuItemAltaActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jMenuItemAltaActionPerformed
        dialogoAlta dialogo=new dialogoAlta(this,true);
        dialogo.setVisible(true);
        refrescarTabla();
    }//GEN-LAST:event_jMenuItemAltaActionPerformed

    private void jbtnAniadirActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jbtnAniadirActionPerformed
        dialogoAlta dialogo=new dialogoAlta(this,true);
        dialogo.setVisible(true);
        refrescarTabla();
        JOptionPane.showMessageDialog(this, ""+logicaNegocio.getListaClientes().size());
    }//GEN-LAST:event_jbtnAniadirActionPerformed

    private void btnEliminarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnEliminarActionPerformed
        if (valorTabla >= 0) {
            logicaNegocio.getListaClientes().remove(valorTabla);
            JOptionPane.showMessageDialog(this, "Usuario elimnado");
            refrescarTabla();
        }else{
            JOptionPane.showMessageDialog(this, "Cliente sin seleccionar de la tabla");
        }
    }//GEN-LAST:event_btnEliminarActionPerformed

    private void btnEditarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnEditarActionPerformed
        if (valorTabla >= 0) {
            Cliente cliente = logicaNegocio.getListaClientes().get(valorTabla);
            logicaNegocio.getListaClientes().remove(valorTabla);
            dialogoAlta dialogo = new dialogoAlta(this,true);
            dialogo.getjButtonAlta().setText("Editar");
            dialogo.getjTextFieldNombre().setText(cliente.getNombre());
            dialogo.getjTextFieldApellidos().setText(cliente.getApellidos());
            dialogo.getjComboBoxProvincia().setSelectedItem(cliente.getProvincia());
            dialogo.setVisible(true);
            if (dialogo.isActive()) {
                logicaNegocio.getListaClientes().add(cliente);
            }
            refrescarTabla();
        }else{
            JOptionPane.showMessageDialog(this, "Cliente sin seleccionar de la tabla");
        }
    }//GEN-LAST:event_btnEditarActionPerformed

    public static void main(String args[]) {
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new PantallaPrincipal().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnEditar;
    private javax.swing.JButton btnEliminar;
    private javax.swing.JMenu jMenu1;
    private javax.swing.JMenuBar jMenuBar1;
    private javax.swing.JMenuItem jMenuItemAlta;
    private javax.swing.JMenu jMenuSalir;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTable jTableClientes;
    private javax.swing.JButton jbtFiltrar;
    private javax.swing.JButton jbtnAniadir;
    private javax.swing.JTextField jtfFiltrar;
    // End of variables declaration//GEN-END:variables
}
