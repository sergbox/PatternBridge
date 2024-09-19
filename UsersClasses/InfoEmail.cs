﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace SendingLettersByMail.UsersClasses
{
    public abstract class InfoEmail
    {
        private string _smtpClientAdress { get; set; }
        private StringPair _emailAdressFrom { get; set; }
        private string _emailPassword { get; set; }
        private StringPair _emailAdressTo { get; set; }
        private string _subject { get; set; }
        private string _body { get; set; }
        private int _port;
        public string SmtpClientAdress
        {
            get { return _smtpClientAdress; }
            set
            {
                _smtpClientAdress = String.IsNullOrWhiteSpace(value) ?
                    throw new ArgumentNullException(nameof(_smtpClientAdress)) :
                    value;
            }
        }

        public StringPair EmailAdressFrom
        {
            get { return _emailAdressFrom; }
            set
            {
                _emailAdressFrom = value ??
                throw new ArgumentNullException(nameof(_emailAdressFrom));
            }
        }
        public string EmailPassword
        {
            get { return _emailPassword; }
            set
            {
                _emailPassword = String.IsNullOrWhiteSpace(value) ?
                    throw new ArgumentNullException(nameof(_emailPassword)) :
                    value;
            }
        }
        public StringPair EmailAdressTo
        {
            get { return _emailAdressTo; }
            set
            {
                _emailAdressTo = value ??
                throw new ArgumentNullException(nameof(_emailAdressTo));
            }
        }
        public string Subject
        {
            get { return _subject; }
            set
            {
                _subject = String.IsNullOrWhiteSpace(value) ?
                    throw new ArgumentNullException(nameof(_subject)) :
                    value;
            }
        }
        public string Body
        {
            get { return _body; }
            set
            {
                _body = String.IsNullOrWhiteSpace(value) ?
                    throw new ArgumentNullException(nameof(value)) :
                    value;
            }
        }
        public int Port
        {
            get { return _port; }
            set { _port = value; }
        }
        protected InfoEmail(StringPair emailAdressTo, string subject, string body)
        {
            EmailAdressTo = emailAdressTo;
            Subject = subject;
            Body = body;
        }
    }
}
