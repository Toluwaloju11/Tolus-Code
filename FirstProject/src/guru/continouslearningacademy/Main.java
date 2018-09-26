package guru.continouslearningacademy;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.remote.DesiredCapabilities;
import org.openqa.selenium.ie.InternetExplorerDriver;
import org.openqa.selenium.By;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.Keys;

public class Main {

    public static void main(String[] args) {

        //System.setProperty("webdriver.ie.driver", "C:\\automation\\drivers\\IEDriverServer.exe");
        System.setProperty("webdriver.ie.driver", "C:\\Users\\Tester\\Automation\\Drivers\\IEDriverServer.exe");
        DesiredCapabilities ieCapabilities = DesiredCapabilities.internetExplorer();
        ieCapabilities.setVersion("11"); // For Internet Explorer 11
        WebDriver driver = new InternetExplorerDriver(ieCapabilities);
        driver.manage().window().maximize();
        driver.get("http://www.continuouslearningacademy.guru/resources/2/first/");
        WebElement element = driver.findElement(By.xpath("//input[@name=‘email’]"));
        element.sendKeys("test@test.org");
        element.sendKeys(Keys.ENTER);

        driverie.close();
    }
}
















/*package guru.continouslearningacademy;

import java.util.*;
public class Main {

    public static void main(String[] args) {
System.out.println("Hello World from EBRD");
int age;
age = 24;
System.out.println("My age is " + age);

int newage = 10;

if (newage < 6){
    System.out.println("Youre too young");
}
        System.out.println("Age is fine");
  }
}****/
