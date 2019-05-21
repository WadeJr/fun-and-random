import pandas as pd
import smtplib
import threading


EmailList = "EmailList.xlsx"
emailAddress = "uptimizedm@gmail.com"
password = ""

msg = "Hellow world\niam"
subject = "Test"
body = "Subject: {}\n\n{}".format(subject, msg)

e = pd.read_excel(EmailList)
emails = e['Emails'].values
server = smtplib.SMTP("smtp.gmail.com", 587)
server.starttls()
server.login(emailAddress, password)



for email in emails:
    server.sendmail(emailAddress, email, body)
server.quit()

