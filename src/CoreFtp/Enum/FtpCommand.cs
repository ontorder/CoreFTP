﻿namespace CoreFtp.Enum;

public enum FtpCommand
{
    NOOP,
    USER,
    PASS,
    QUIT,
    EPSV,
    PASV,
    CWD,
    PWD,
    CLNT,
    NLST,
    LIST,
    MLSD,
    RETR,
    STOR,
    DELE,
    MKD,
    RMD,
    RNFR,
    RNTO,
    SIZE,
    TYPE,
    FEAT,
    PBSZ,
    PROT
}
