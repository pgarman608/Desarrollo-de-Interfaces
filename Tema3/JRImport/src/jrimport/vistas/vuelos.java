/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/GUIForms/JFrame.java to edit this template
 */
package jrimport.vistas;

import controlador.ConectarBD;
import java.awt.Desktop;
import java.io.File;
import java.io.IOException;
import java.util.HashMap;
import java.util.Map;
import java.util.logging.Level;
import java.util.logging.Logger;
import jrimport.controladores.ConectarBD;
import net.sf.jasperreports.engine.JRException;
import net.sf.jasperreports.engine.JasperExportManager;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.JasperPrint;
import net.sf.jasperreports.view.JasperViewer;
import org.mariadb.jdbc.Connection;

/**
 *
 * @author japa
 */
public class vuelos extends javax.swing.JFrame {

    /**
     * Creates new form vuelos
     */
    private final ConectarBD conecta;
    static private Connection con;

    static public Connection getCon() {
        return con;
    }
    
    public vuelos() {
        initComponents();
        setLocationRelativeTo(null);
        // conecta a la BD
        conecta = new ConectarBD();
	
        con = (Connection) conecta.getConexion();
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jButtonAeronaves = new javax.swing.JButton();
        jButtonListadoAeronaves = new javax.swing.JButton();
        jButtonCampos = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jButtonAeronaves.setText("Aeronaves");
        jButtonAeronaves.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonAeronavesActionPerformed(evt);
            }
        });

        jButtonListadoAeronaves.setText("Listado\\n Aeronaves");
        jButtonListadoAeronaves.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonListadoAeronavesActionPerformed(evt);
            }
        });

        jButtonCampos.setText("Campos");
        jButtonCampos.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonCamposActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(46, 46, 46)
                .addComponent(jButtonCampos)
                .addGap(40, 40, 40)
                .addComponent(jButtonAeronaves)
                .addGap(18, 18, 18)
                .addComponent(jButtonListadoAeronaves, javax.swing.GroupLayout.PREFERRED_SIZE, 132, Short.MAX_VALUE)
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(78, 78, 78)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jButtonAeronaves)
                    .addComponent(jButtonListadoAeronaves, javax.swing.GroupLayout.PREFERRED_SIZE, 56, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jButtonCampos))
                .addContainerGap(166, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jButtonAeronavesActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonAeronavesActionPerformed
        
    }//GEN-LAST:event_jButtonAeronavesActionPerformed

    private void jButtonListadoAeronavesActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonListadoAeronavesActionPerformed
        Connection conexion;
        try {
            conexion=getCon();
            Map parametros=new HashMap();
            parametros.clear();
            //parametros.put("NINGUNO", "VACIO");
            String informe="aeronaves.jasper";
            JasperPrint print=JasperFillManager.fillReport(informe,parametros,conexion);
            JasperExportManager.exportReportToPdfFile(print,"aeronaves.pdf");
            File archivo=new File("aeronaves.pdf");
            //Desktop.getDesktop().open(archivo);
            
            JasperViewer viewer = new JasperViewer(print,false);
            viewer.setTitle("AERONAVES");
            viewer.setVisible(true);

        } catch (JRException ex) {
            Logger.getLogger(vuelos.class.getName()).log(Level.SEVERE, null, ex);
        }
    }//GEN-LAST:event_jButtonListadoAeronavesActionPerformed

    private void jButtonCamposActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonCamposActionPerformed
        mtocampos campos=new mtocampos(this, true);
        campos.setVisible(true);
    }//GEN-LAST:event_jButtonCamposActionPerformed

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
            java.util.logging.Logger.getLogger(vuelos.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(vuelos.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(vuelos.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(vuelos.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new vuelos().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButtonAeronaves;
    private javax.swing.JButton jButtonCampos;
    private javax.swing.JButton jButtonListadoAeronaves;
    // End of variables declaration//GEN-END:variables
}
