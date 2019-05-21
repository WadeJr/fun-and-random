from selenium import webdriver

driver = webdriver.MicrosoftEdge()
driver.get("www.wechall.net/challenge/training/programming1/index.php?action=request")
elem = driver.find_element_by_link_text("this link")
elem.click()