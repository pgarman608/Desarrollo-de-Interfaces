/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/GUIForms/JFrame.java to edit this template
 */
package jrimport.vistas;
import jrimport.controladores.ConectarBD;
import java.io.File;
import java.io.IOException;
import java.util.HashMap;
import java.util.Map;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;
import net.sf.jasperreports.engine.JRException;
import net.sf.jasperreports.engine.JasperExportManager;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.JasperPrint;
import net.sf.jasperreports.view.JasperViewer;
import org.mariadb.jdbc.Connection;
public class nba extends javax.swing.JFrame {
    private final ConectarBD conecta;
    static private Connection con;
    public nba() {
        initComponents();
        
        setLocationRelativeTo(null);
        
        conecta = new ConectarBD();
	
        con = (Connection) conecta.getConexion();
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jbtLE = new javax.swing.JButton();
        jbtLJugadores = new javax.swing.JButton();
        jbtListJugporEqu = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jbtLE.setText("Listar Equipos");
        jbtLE.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jbtLEActionPerformed(evt);
            }
        });

        jbtLJugadores.setText("Listar Jugadores");
        jbtLJugadores.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jbtLJugadoresActionPerformed(evt);
            }
        });

        jbtListJugporEqu.setText("Listar jugadores por equipo");
        jbtListJugporEqu.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jbtListJugporEquActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addComponent(jbtLJugadores)
                        .addGap(18, 18, 18)
                        .addComponent(jbtLE)
                        .addGap(0, 0, Short.MAX_VALUE))
                    .addComponent(jbtListJugporEqu, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jbtLE)
                    .addComponent(jbtLJugadores))
                .addGap(18, 18, 18)
                .addComponent(jbtListJugporEqu)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jbtLJugadoresActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jbtLJugadoresActionPerformed
        Connection conexion;
        try {
            conexion = getCon();
            Map parametros = new HashMap();
            parametros.clear();
            String informe = ".//jugadores.jasper";
            JasperPrint print = JasperFillManager.fillReport(informe,parametros,conexion);
            JasperExportManager.exportReportToPdfFile(print,"jugadores.pdf");
            File f = new File("jugadores.pdf");
            JasperViewer viewer = new JasperViewer(print,false);
            viewer.setTitle("Lista de jugadores");
            viewer.setVisible(true);
        } catch (JRException ex) {
            Logger.getLogger(nba.class.getName()).log(Level.SEVERE, null, ex);
        }
    }//GEN-LAST:event_jbtLJugadoresActionPerformed

    private void jbtLEActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jbtLEActionPerformed
        Connection conexion;
        try {
            conexion = getCon();
            Map parametros = new HashMap();
            parametros.clear();
            String informe = ".//equipos.jasper";
            JasperPrint print = JasperFillManager.fillReport(informe,parametros,conexion);
            JasperExportManager.exportReportToPdfFile(print,"equipos.pdf");
            File f = new File("equipos.pdf");
            JasperViewer viewer = new JasperViewer(print,false);
            viewer.setTitle("Lista de equipos");
            viewer.setVisible(true);
        } catch (JRException ex) {
            System.out.println(ex.getMessage());
        }
    }//GEN-LAST:event_jbtLEActionPerformed

    private void jbtListJugporEquActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jbtListJugporEquActionPerformed
        String parametro = JOptionPane.showInputDialog(this, "¿Qué equipo eliges?");
        Connection conexion;
        if (parametro != null) {
            try {
                conexion = getCon();
                Map parametros = new HashMap();
                parametros.put("Equipo", parametro);
                String informe = ".//2a.jugadores_equipo.jasper";
                JasperPrint print = JasperFillManager.fillReport(informe, parametros, conexion);
                JasperExportManager.exportReportToPdfFile(print, "2a.jugadores_equipo.pdf");
                File f = new File("2a.jugadores_equipo.pdf");
                JasperViewer viewer = new JasperViewer(print, false);
                viewer.setTitle("Lista de jugadores por equipo buscado");
                viewer.setVisible(true);
            } catch (JRException ex) {
                System.out.println(ex.getMessage());
            }
        }else{
            JOptionPane.showMessageDialog(this, "No has seleccionado ninguno");
        }
        
    }//GEN-LAST:event_jbtListJugporEquActionPerformed

    public static Connection getCon() {
        return con;
    }
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
            java.util.logging.Logger.getLogger(nba.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(nba.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(nba.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(nba.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new nba().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jbtLE;
    private javax.swing.JButton jbtLJugadores;
    private javax.swing.JButton jbtListJugporEqu;
    // End of variables declaration//GEN-END:variables
}
