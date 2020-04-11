import ClockPkg.Clock;
import java.awt.Color;
import java.awt.FlowLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JButton;
import javax.swing.JFrame;
import static javax.swing.JFrame.EXIT_ON_CLOSE;
public class ZPK {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		JFrame frame = new JFrame("Zegar testowy");
		Clock clock = new Clock();
                clock.setPrimaryColor(Color.lightGray);
                clock.setSecondaryColor(Color.gray.darker());
                clock.create();
                frame.add(clock);
                frame.setSize(800, 280);
                frame.setVisible(true);
                JButton colorCh = new JButton("Zmień kolor na zielony");
                JButton colorCh2 = new JButton("Zmień kolor na czerwony");
                JButton colorCh3 = new JButton("Zmień kolor na żółty/niebieski");
                FlowLayout layout = new FlowLayout();
                frame.setLayout(layout);
                frame.add(colorCh);
                frame.add(colorCh2);
                frame.add(colorCh3);
                frame.setDefaultCloseOperation(EXIT_ON_CLOSE);
                
                colorCh.addActionListener(new ActionListener() {
                    @Override
                    public void actionPerformed(ActionEvent e) {
                        clock.setPrimaryColor(Color.green.brighter());
                        clock.setSecondaryColor(Color.green.darker().darker().darker());
                        clock.colorRefresh();
                        
                    }
                });
                
                colorCh2.addActionListener(new ActionListener() {
                    @Override
                    public void actionPerformed(ActionEvent e) {
                        clock.setPrimaryColor(Color.red.brighter());
                        clock.setSecondaryColor(Color.red.darker().darker().darker());
                        clock.colorRefresh();
                        
                    }
                });
                
                colorCh3.addActionListener(new ActionListener() {
                    @Override
                    public void actionPerformed(ActionEvent e) {
                        clock.setPrimaryColor(Color.yellow.brighter());
                        clock.setSecondaryColor(Color.cyan.darker().darker().darker());
                        clock.colorRefresh();
                        
                    }
                });
                clock.run();        
	}

}
