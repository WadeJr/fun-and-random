from selenium import webdriver
from selenium.webdriver.common.desired_capabilities import DesiredCapabilities


driver = webdriver.Chrome('C:\\DRIVERS\\chromedriver_win32\\chromedriver.exe')

#driver = webdriver.Chrome()
# driver = webdriver.Chrome("C:/Users/wade2/AppData/Local/Packages/CanonicalGroupLimited.UbuntuonWindows_79rhkp1fndgsc/LocalState/rootfs/usr/local/selenium/webdriver/Chrome/chromedriver_win32/chromedriver.exe")

#driver = webdriver.Edge("C:\Program Files (x86)\Microsoft Web Driver\MicrosoftWebDriver.exe")
#driver.get("www.wechall.net/challenge/training/programming1/index.php?action=request")
#elem = driver.find_element_by_link_text("this link")
#elem.click()