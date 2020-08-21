using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Social.Database.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence(
                name: "JIS_SEQUENCE");

            migrationBuilder.CreateSequence(
                name: "S_NEW_ACCESS_ROLE_ID");

            migrationBuilder.CreateSequence(
                name: "S_NEW_ACCESS_USER_ID");

            migrationBuilder.CreateSequence(
                name: "S_NEW_ACCOUNT_ID");

            migrationBuilder.CreateSequence(
                name: "S_NEW_ADDRESS_POSTCODE_ID");

            migrationBuilder.CreateSequence(
                name: "S_NEW_CATEGORY_DOC_ID");

            migrationBuilder.CreateSequence(
                name: "S_NEW_JINTERDEP_NUM");

            migrationBuilder.CreateSequence(
                name: "S_NEW_JIRS");

            migrationBuilder.CreateSequence(
                name: "S_NEW_NAVIGATOR_ID");

            migrationBuilder.CreateSequence(
                name: "S_NEW_NUM");

            migrationBuilder.CreateSequence(
                name: "S_NEW_PERSON_ID");

            migrationBuilder.CreateSequence(
                name: "S_NEW_PERSONS_DOC_ID");

            migrationBuilder.CreateSequence(
                name: "S_NEW_PERSONS_HISTORYS_ID");

            migrationBuilder.CreateSequence(
                name: "S_NEW_ROLE_OBJECTS_ID");

            migrationBuilder.CreateSequence(
                name: "S_NEW_SERVISES_DOC_ID");

            migrationBuilder.CreateSequence(
                name: "S_NEW_SERVISES_HISTORYS_ID");

            migrationBuilder.CreateSequence(
                name: "S_NEW_SERVISES_ID");

            migrationBuilder.CreateSequence(
                name: "S_NEW_SERVISES_NUM");

            migrationBuilder.CreateSequence(
                name: "S_NEW_SERVISES_REST_NUM");

            migrationBuilder.CreateSequence(
                name: "S_NEW_SHO_ID");

            migrationBuilder.CreateSequence(
                name: "S_NEW_USER_ID");

            migrationBuilder.CreateSequence(
                name: "S_NEW_ZAGS_DATA_ID");

            migrationBuilder.CreateSequence(
                name: "UID_SEQUENCE");

            migrationBuilder.CreateTable(
                name: "JOURNAL_INTERDEPART_SOCIAL",
                columns: table => new
                {
                    ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    DATE_CREATE = table.Column<DateTime>(type: "DATE", nullable: false, defaultValueSql: "sysdate "),
                    JOURNAL_NUMBER = table.Column<decimal>(type: "NUMBER", nullable: true),
                    JOURNAL_STATUS = table.Column<byte>(type: "NUMBER(2)", nullable: false, defaultValueSql: "0 "),
                    ID_USER = table.Column<decimal>(type: "NUMBER", nullable: false, defaultValueSql: "1 "),
                    DATE_INSERT = table.Column<DateTime>(type: "DATE", nullable: false, defaultValueSql: "sysdate "),
                    DATE_UPDATE = table.Column<DateTime>(type: "DATE", nullable: false, defaultValueSql: "sysdate "),
                    VERSION = table.Column<decimal>(type: "NUMBER", nullable: false, defaultValueSql: "0 "),
                    DATE_FINISHED = table.Column<DateTime>(type: "DATE", nullable: true),
                    MIN_DOC_DATE = table.Column<DateTime>(type: "DATE", nullable: true),
                    MAX_DOC_DATE = table.Column<DateTime>(type: "DATE", nullable: true),
                    SERVIES_COUNT = table.Column<decimal>(type: "NUMBER", nullable: true, defaultValueSql: @"0
")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JOURNAL_INTERDEPART_SOCIAL", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PERSONS_SOCIAL",
                columns: table => new
                {
                    PERSON_ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    SURNAME = table.Column<string>(type: "VARCHAR2(200)", nullable: true),
                    NAME = table.Column<string>(type: "VARCHAR2(50)", nullable: true),
                    PATRONYMIC = table.Column<string>(type: "VARCHAR2(100)", nullable: true),
                    BDATE = table.Column<DateTime>(type: "DATE", nullable: true),
                    SEX = table.Column<int>(nullable: true, defaultValueSql: "1"),
                    COUNTRY_ID = table.Column<decimal>(type: "NUMBER", nullable: false, defaultValueSql: "167 "),
                    ADDRESS_ID = table.Column<decimal>(type: "NUMBER", nullable: true),
                    APARTMENT = table.Column<string>(type: "VARCHAR2(10)", nullable: true),
                    PHONE_HOME = table.Column<string>(type: "VARCHAR2(30)", nullable: true),
                    PHONE_WORK = table.Column<string>(type: "VARCHAR2(30)", nullable: true),
                    PHONE_MOBILE = table.Column<string>(type: "VARCHAR2(30)", nullable: true),
                    SNILS = table.Column<string>(type: "VARCHAR2(14)", nullable: true),
                    DATE_INSERT = table.Column<DateTime>(type: "DATE", nullable: true, defaultValueSql: "sysdate "),
                    DATE_UPDATE = table.Column<DateTime>(type: "DATE", nullable: true, defaultValueSql: "sysdate "),
                    ID_USER = table.Column<decimal>(type: "NUMBER", nullable: true),
                    VERSION = table.Column<decimal>(type: "NUMBER", nullable: false, defaultValueSql: "0 "),
                    ADDRESS = table.Column<string>(type: "VARCHAR2(1000)", nullable: true),
                    IS_REPRESENT = table.Column<decimal>(type: "NUMBER", nullable: true, defaultValueSql: "0"),
                    DDATE = table.Column<DateTime>(type: "DATE", nullable: true),
                    ADATE = table.Column<DateTime>(type: "DATE", nullable: true),
                    ANUM = table.Column<string>(type: "VARCHAR2(15)", nullable: true),
                    IS_LEGAL_REPRESENT = table.Column<decimal>(type: "NUMBER", nullable: true, defaultValueSql: "0"),
                    WORK_ID = table.Column<decimal>(type: "NUMBER", nullable: true),
                    POST_ID = table.Column<decimal>(type: "NUMBER", nullable: true),
                    EMAIL = table.Column<string>(type: "VARCHAR2(100)", nullable: true),
                    BIRTHPLACE = table.Column<string>(type: "VARCHAR2(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PERSON_SOC_ID", x => x.PERSON_ID);
                });

            migrationBuilder.CreateTable(
                name: "SCHOOL",
                columns: table => new
                {
                    ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    NAME = table.Column<string>(type: "VARCHAR2(500)", nullable: false),
                    ABB_NAME = table.Column<string>(type: "VARCHAR2(100)", nullable: true),
                    DATE_INSERT = table.Column<DateTime>(type: "DATE", nullable: false, defaultValueSql: "sysdate "),
                    DATE_UPDATE = table.Column<DateTime>(type: "DATE", nullable: false, defaultValueSql: "sysdate "),
                    ID_USER = table.Column<decimal>(type: "NUMBER", nullable: false, defaultValueSql: "1 "),
                    VERSION = table.Column<decimal>(type: "NUMBER", nullable: false, defaultValueSql: "0 ")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCHOOL", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SOCIAL_PERIOD",
                columns: table => new
                {
                    ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    NAME = table.Column<string>(type: "VARCHAR2(50)", nullable: true),
                    PERIOD_BEGIN = table.Column<DateTime>(type: "DATE", nullable: true),
                    PERIOD_END = table.Column<DateTime>(type: "DATE", nullable: true),
                    GET_DOC_BEGIN = table.Column<DateTime>(type: "DATE", nullable: true),
                    GET_DOC_END = table.Column<DateTime>(type: "DATE", nullable: true),
                    IS_ACTIVE = table.Column<int>(nullable: true, defaultValueSql: "0"),
                    DATE_INSERT = table.Column<DateTime>(type: "DATE", nullable: true, defaultValueSql: "sysdate"),
                    DATE_UPDATE = table.Column<DateTime>(type: "DATE", nullable: true, defaultValueSql: "sysdate"),
                    VERSION = table.Column<decimal>(type: "NUMBER", nullable: true, defaultValueSql: "0"),
                    ID_USER = table.Column<decimal>(type: "NUMBER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SOCIAL_PERIOD", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TypeDocs",
                columns: table => new
                {
                    Id = table.Column<decimal>(nullable: false),
                    TypeDocName = table.Column<string>(nullable: true),
                    CorporateCode = table.Column<string>(nullable: true),
                    Parent = table.Column<decimal>(nullable: true),
                    HasChild = table.Column<decimal>(nullable: false),
                    Version = table.Column<decimal>(nullable: false),
                    IdUser = table.Column<decimal>(nullable: false),
                    DateInsert = table.Column<DateTime>(nullable: false),
                    DateUpdate = table.Column<DateTime>(nullable: false),
                    TypeDocNameRest = table.Column<string>(nullable: true),
                    Ord = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeDocs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PERSONS_SOCIAL_DOC",
                columns: table => new
                {
                    ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    TYPE_DOC_ID = table.Column<decimal>(type: "NUMBER", nullable: true),
                    PERSON_ID = table.Column<decimal>(type: "NUMBER", nullable: true),
                    VERSION_DOC = table.Column<decimal>(type: "NUMBER", nullable: false, defaultValueSql: "1 "),
                    SER = table.Column<string>(type: "VARCHAR2(30)", nullable: true),
                    NUM = table.Column<string>(type: "VARCHAR2(30)", nullable: true),
                    GET = table.Column<string>(type: "VARCHAR2(1000)", nullable: true),
                    GET_DATE = table.Column<DateTime>(type: "DATE", nullable: true),
                    DATE_INSERT = table.Column<DateTime>(type: "DATE", nullable: false, defaultValueSql: "sysdate "),
                    DATE_UPDATE = table.Column<DateTime>(type: "DATE", nullable: false, defaultValueSql: "sysdate "),
                    ID_USER = table.Column<decimal>(type: "NUMBER", nullable: true),
                    NUM_SHEET = table.Column<decimal>(type: "NUMBER", nullable: false, defaultValueSql: "1 "),
                    VERSION = table.Column<decimal>(type: "NUMBER", nullable: false, defaultValueSql: "0 "),
                    DATE_OUT = table.Column<DateTime>(type: "DATE", nullable: true),
                    DATE_IN = table.Column<DateTime>(type: "DATE", nullable: true),
                    BDATE = table.Column<DateTime>(type: "DATE", nullable: true),
                    GUID = table.Column<string>(type: "VARCHAR2(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PERSONS_SOCIAL_DOC", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PERSONS_SOC_ID",
                        column: x => x.PERSON_ID,
                        principalTable: "PERSONS_SOCIAL",
                        principalColumn: "PERSON_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PERSONS_SOCIAL_LEGAL_REPRESENT",
                columns: table => new
                {
                    ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    ID_LEGAL_REPRESENT = table.Column<decimal>(type: "NUMBER", nullable: false),
                    ID_PERSON = table.Column<decimal>(type: "NUMBER", nullable: false),
                    DATE_INSERT = table.Column<DateTime>(type: "DATE", nullable: false, defaultValueSql: "sysdate "),
                    DATE_UPDATE = table.Column<DateTime>(type: "DATE", nullable: false, defaultValueSql: "sysdate "),
                    ID_USER = table.Column<decimal>(type: "NUMBER", nullable: false),
                    VERSION = table.Column<decimal>(type: "NUMBER", nullable: false, defaultValueSql: "0 ")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PERSONS_SOCIAL_LEGAL_REPRESENT", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PERSON_SOC_LEGAL_REPRESENT1",
                        column: x => x.ID_LEGAL_REPRESENT,
                        principalTable: "PERSONS_SOCIAL",
                        principalColumn: "PERSON_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PERSON_SOC_LEGAL_REPRESENT2",
                        column: x => x.ID_PERSON,
                        principalTable: "PERSONS_SOCIAL",
                        principalColumn: "PERSON_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PERSONS_SOCIAL_REPRESENT",
                columns: table => new
                {
                    ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    ID_REPRESENT = table.Column<decimal>(type: "NUMBER", nullable: false),
                    ID_PERSON = table.Column<decimal>(type: "NUMBER", nullable: false),
                    DATE_INSERT = table.Column<DateTime>(type: "DATE", nullable: false, defaultValueSql: "sysdate "),
                    DATE_UPDATE = table.Column<DateTime>(type: "DATE", nullable: false, defaultValueSql: "sysdate "),
                    ID_USER = table.Column<decimal>(type: "NUMBER", nullable: false),
                    VERSION = table.Column<decimal>(type: "NUMBER", nullable: false, defaultValueSql: "0 ")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PERSONS_SOCIAL_REPRESENT", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PERSON_SOC_REPRESENT2",
                        column: x => x.ID_PERSON,
                        principalTable: "PERSONS_SOCIAL",
                        principalColumn: "PERSON_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PERSON_SOC_REPRESENT1",
                        column: x => x.ID_REPRESENT,
                        principalTable: "PERSONS_SOCIAL",
                        principalColumn: "PERSON_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SOCIAL_WAY",
                columns: table => new
                {
                    ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    SOCIAL_PERIOD_ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    NAME = table.Column<string>(type: "VARCHAR2(200)", nullable: true),
                    SIGN_TERRITORY = table.Column<int>(nullable: true),
                    DATE_INSERT = table.Column<DateTime>(type: "DATE", nullable: true, defaultValueSql: "sysdate"),
                    DATE_UPDATE = table.Column<DateTime>(type: "DATE", nullable: true, defaultValueSql: "sysdate"),
                    VERSION = table.Column<decimal>(type: "NUMBER", nullable: true, defaultValueSql: "0"),
                    ID_USER = table.Column<decimal>(type: "NUMBER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SOCIAL_WAY", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SOC_WAY_PERIOD_ID",
                        column: x => x.SOCIAL_PERIOD_ID,
                        principalTable: "SOCIAL_PERIOD",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PERSONS_SOCIAL_DOC_FILE",
                columns: table => new
                {
                    ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    ID_PERSONS_DOC = table.Column<decimal>(type: "NUMBER", nullable: true),
                    DATE_INSERT = table.Column<DateTime>(type: "DATE", nullable: false, defaultValueSql: "sysdate "),
                    DATE_UPDATE = table.Column<DateTime>(type: "DATE", nullable: false, defaultValueSql: "sysdate "),
                    ID_USER = table.Column<decimal>(type: "NUMBER", nullable: true, defaultValueSql: "1"),
                    VERSION = table.Column<decimal>(type: "NUMBER", nullable: false, defaultValueSql: "0 "),
                    FILE_NAME = table.Column<string>(type: "VARCHAR2(256)", nullable: false),
                    FILE_SIZE = table.Column<decimal>(type: "NUMBER", nullable: true),
                    DATE_FILE_CREATE = table.Column<DateTime>(type: "DATE", nullable: true),
                    NOTE = table.Column<string>(type: "VARCHAR2(500)", nullable: true),
                    FILE_BODY = table.Column<byte[]>(type: "BLOB", nullable: true),
                    GUID = table.Column<string>(type: "VARCHAR2(200)", nullable: true),
                    EXTENSION = table.Column<string>(type: "VARCHAR2(256)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PERSONS_SOCIAL_DOC_FILE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PERSONS_SOC_DOC_FILE_PD",
                        column: x => x.ID_PERSONS_DOC,
                        principalTable: "PERSONS_SOCIAL_DOC",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SOCIAL_PLACE",
                columns: table => new
                {
                    ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    SOCIAL_WAY_ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    NAME = table.Column<string>(type: "VARCHAR2(500)", nullable: true),
                    COMMENTS = table.Column<string>(type: "VARCHAR2(500)", nullable: true),
                    DATE_INSERT = table.Column<DateTime>(type: "DATE", nullable: true, defaultValueSql: "sysdate"),
                    DATE_UPDATE = table.Column<DateTime>(type: "DATE", nullable: true, defaultValueSql: "sysdate"),
                    VERSION = table.Column<decimal>(type: "NUMBER", nullable: true, defaultValueSql: "0"),
                    ID_USER = table.Column<decimal>(type: "NUMBER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SOCIAL_PLACE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SOC_PLACE_WAY_ID",
                        column: x => x.SOCIAL_WAY_ID,
                        principalTable: "SOCIAL_WAY",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SOCIAL_SESSION",
                columns: table => new
                {
                    ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    SOCIAL_PLACE_ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    NUM_SESSION = table.Column<decimal>(type: "NUMBER", nullable: false),
                    DATE_BEGIN = table.Column<DateTime>(type: "DATE", nullable: true),
                    DATE_END = table.Column<DateTime>(type: "DATE", nullable: true),
                    COMMENTS = table.Column<string>(type: "VARCHAR2(500)", nullable: true),
                    COUNT = table.Column<decimal>(type: "NUMBER", nullable: true),
                    DATE_INSERT = table.Column<DateTime>(type: "DATE", nullable: true, defaultValueSql: "sysdate"),
                    DATE_UPDATE = table.Column<DateTime>(type: "DATE", nullable: true, defaultValueSql: "sysdate"),
                    VERSION = table.Column<decimal>(type: "NUMBER", nullable: true, defaultValueSql: "0"),
                    ID_USER = table.Column<decimal>(type: "NUMBER", nullable: true),
                    ID_EVENT_SESSION = table.Column<decimal>(type: "NUMBER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SOCIAL_SESSION", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SOC_SESSION_PLACE_ID",
                        column: x => x.SOCIAL_PLACE_ID,
                        principalTable: "SOCIAL_PLACE",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EVENT_SOCIAL_SESSION",
                columns: table => new
                {
                    ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    SESSION_ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    EVENT = table.Column<decimal>(type: "NUMBER", nullable: false, defaultValueSql: "0 "),
                    DATE_INSERT = table.Column<DateTime>(type: "DATE", nullable: false, defaultValueSql: "sysdate "),
                    DATE_UPDATE = table.Column<DateTime>(type: "DATE", nullable: false, defaultValueSql: "sysdate "),
                    ID_USER = table.Column<decimal>(type: "NUMBER", nullable: false, defaultValueSql: "1 "),
                    VERSION = table.Column<decimal>(type: "NUMBER", nullable: false, defaultValueSql: "0 "),
                    NOTE = table.Column<string>(type: "VARCHAR2(1000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EVENT_SOCIAL_SESSION", x => x.ID);
                    table.ForeignKey(
                        name: "FK_EVENT_SOC_SESSION_LIST_ID",
                        column: x => x.SESSION_ID,
                        principalTable: "SOCIAL_SESSION",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SOCIAL_DELIVERY",
                columns: table => new
                {
                    ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    SOCIAL_SESSION_ID = table.Column<decimal>(type: "NUMBER", nullable: true),
                    METHOD = table.Column<int>(nullable: true),
                    DATE_INSERT = table.Column<DateTime>(type: "DATE", nullable: true, defaultValueSql: "sysdate"),
                    DATE_UPDATE = table.Column<DateTime>(type: "DATE", nullable: true, defaultValueSql: "sysdate"),
                    VERSION = table.Column<decimal>(type: "NUMBER", nullable: true, defaultValueSql: "0"),
                    ID_USER = table.Column<decimal>(type: "NUMBER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SOCIAL_DELIVERY", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SOC_DELIVERY_SESSION_ID",
                        column: x => x.SOCIAL_SESSION_ID,
                        principalTable: "SOCIAL_SESSION",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "JOURNAL_INTERDEPART_SERV_SOCIA",
                columns: table => new
                {
                    ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    ID_JI_REST = table.Column<decimal>(type: "NUMBER", nullable: false),
                    ID_SERVICE = table.Column<decimal>(type: "NUMBER", nullable: false),
                    VERSION = table.Column<decimal>(type: "NUMBER", nullable: false, defaultValueSql: "0 "),
                    DATE_INSERT = table.Column<DateTime>(type: "DATE", nullable: false, defaultValueSql: "sysdate "),
                    DATE_UPDATE = table.Column<DateTime>(type: "DATE", nullable: false, defaultValueSql: "sysdate "),
                    ID_USER = table.Column<decimal>(type: "NUMBER", nullable: false, defaultValueSql: "1 "),
                    INTERDEPART_STATUS = table.Column<int>(nullable: true, defaultValueSql: "1"),
                    DATE_FINISHED = table.Column<DateTime>(type: "DATE", nullable: true),
                    FLAG_FMS = table.Column<int>(nullable: true, defaultValueSql: "1"),
                    PERSON_FM = table.Column<string>(type: "VARCHAR2(200)", nullable: true),
                    PERSON_IM = table.Column<string>(type: "VARCHAR2(50)", nullable: true),
                    PERSON_OT = table.Column<string>(type: "VARCHAR2(100)", nullable: true),
                    PERSON_DR = table.Column<DateTime>(type: "DATE", nullable: true),
                    PERSON_BPLACE = table.Column<string>(type: "VARCHAR2(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JOURNAL_INTERDEPART_SERV_SOCIA", x => x.ID);
                    table.ForeignKey(
                        name: "FK_JI_SERVICE_SOC_JOURNAL_ID",
                        column: x => x.ID_JI_REST,
                        principalTable: "JOURNAL_INTERDEPART_SOCIAL",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SERVISES_SOCIAL",
                columns: table => new
                {
                    ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    PERSON_ID = table.Column<decimal>(type: "NUMBER", nullable: true),
                    CATEGORY_ID = table.Column<decimal>(type: "NUMBER", nullable: true, defaultValueSql: "3"),
                    DATE_REG = table.Column<DateTime>(type: "DATE", nullable: true, defaultValueSql: "sysdate"),
                    DOC_NUM = table.Column<string>(type: "VARCHAR2(20)", nullable: true),
                    SESSION_ID = table.Column<decimal>(type: "NUMBER", nullable: true),
                    DELIVERY = table.Column<int>(nullable: true),
                    ID_SERVICE_HISTORYS = table.Column<decimal>(type: "NUMBER", nullable: true),
                    ID_CURR_LEGAL_REPRESENT = table.Column<decimal>(type: "NUMBER", nullable: true),
                    ID_OPER_INSERT = table.Column<decimal>(type: "NUMBER", nullable: true, defaultValueSql: "1"),
                    ID_CONTR_UPDATE = table.Column<decimal>(type: "NUMBER", nullable: true),
                    ROOM_COUPON = table.Column<string>(type: "VARCHAR2(20)", nullable: true),
                    DATE_INSERT = table.Column<DateTime>(type: "DATE", nullable: false, defaultValueSql: "sysdate "),
                    DATE_UPDATE = table.Column<DateTime>(type: "DATE", nullable: false, defaultValueSql: "sysdate "),
                    VERSION = table.Column<decimal>(type: "NUMBER", nullable: false, defaultValueSql: "0 "),
                    SCHOOL_ID = table.Column<decimal>(type: "NUMBER", nullable: true),
                    CLASS = table.Column<string>(type: "VARCHAR2(5)", maxLength: 5, nullable: true),
                    ID_CURR_REPRESENT = table.Column<decimal>(type: "NUMBER", nullable: true),
                    RESERVE = table.Column<decimal>(type: "NUMBER", nullable: false, defaultValueSql: "0 "),
                    INFO_IP_ADRESS = table.Column<string>(type: "VARCHAR2(20)", nullable: true),
                    INFO_BROWSER = table.Column<string>(type: "VARCHAR2(250)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SERVISES_SOCIAL", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SERVISES_INV_LEG_REPR_ID",
                        column: x => x.ID_CURR_LEGAL_REPRESENT,
                        principalTable: "PERSONS_SOCIAL",
                        principalColumn: "PERSON_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SERVISES_INV_REPR_ID",
                        column: x => x.ID_CURR_REPRESENT,
                        principalTable: "PERSONS_SOCIAL",
                        principalColumn: "PERSON_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SERVISES_INV_PERSON_ID",
                        column: x => x.PERSON_ID,
                        principalTable: "PERSONS_SOCIAL",
                        principalColumn: "PERSON_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SERVISES_INV_SESSION_ID",
                        column: x => x.SESSION_ID,
                        principalTable: "SOCIAL_SESSION",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SERVISES_SOCIAL_DOC",
                columns: table => new
                {
                    ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    SERVISES_ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    DATE_INSERT = table.Column<DateTime>(type: "DATE", nullable: false, defaultValueSql: "sysdate "),
                    DATE_UPDATE = table.Column<DateTime>(type: "DATE", nullable: false, defaultValueSql: "sysdate "),
                    ID_USER = table.Column<decimal>(type: "NUMBER", nullable: true),
                    VERSION = table.Column<decimal>(type: "NUMBER", nullable: false, defaultValueSql: "0 "),
                    FILE_NAME = table.Column<string>(type: "VARCHAR2(256)", nullable: false),
                    FILE_SIZE = table.Column<decimal>(type: "NUMBER", nullable: true),
                    DATE_FILE_CREATE = table.Column<DateTime>(type: "DATE", nullable: true),
                    EXTENSION = table.Column<string>(type: "VARCHAR2(5)", nullable: true),
                    NOTE = table.Column<string>(type: "VARCHAR2(100)", nullable: true),
                    FILE_BODY = table.Column<byte[]>(type: "BLOB", nullable: true),
                    TYPE_SERVICE_DOC = table.Column<int>(nullable: false, defaultValueSql: "0 "),
                    NUM_SHEET = table.Column<decimal>(type: "NUMBER", nullable: false, defaultValueSql: "0 ")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SERVISES_SOCIAL_DOC", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SERVISE_INV_DOC_SERVISES_ID",
                        column: x => x.SERVISES_ID,
                        principalTable: "SERVISES_SOCIAL",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SERVISES_SOCIAL_FAMILY_CAT",
                columns: table => new
                {
                    ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    SERVISES_SOCIAL_ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    CATEGORY_FAMILY_ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    NUM_ATTRIBUTE = table.Column<string>(type: "NVARCHAR2(50)", nullable: true),
                    DATE_ATTRIBUTE = table.Column<DateTime>(type: "DATE", nullable: true),
                    DATE_INSERT = table.Column<DateTime>(type: "DATE", nullable: false, defaultValueSql: "sysdate "),
                    DATE_UPDATE = table.Column<DateTime>(type: "DATE", nullable: false, defaultValueSql: "sysdate "),
                    ID_USER = table.Column<decimal>(type: "NUMBER", nullable: true),
                    VERSION = table.Column<decimal>(type: "NUMBER", nullable: false, defaultValueSql: "0 ")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SERVISES_SOCIAL_FAMILY_CAT", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SERVISES_SOC_ID",
                        column: x => x.SERVISES_SOCIAL_ID,
                        principalTable: "SERVISES_SOCIAL",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SERVISES_SOCIAL_HISTORYS",
                columns: table => new
                {
                    ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    SERVISES_ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    HISTORY_TEXT = table.Column<string>(type: "VARCHAR2(500)", nullable: true),
                    HISTORY_DATE = table.Column<DateTime>(type: "DATE", nullable: false, defaultValueSql: "sysdate "),
                    ID_USER = table.Column<decimal>(type: "NUMBER", nullable: true),
                    ID_STATUS = table.Column<decimal>(type: "NUMBER", nullable: true),
                    ID_TYPE_FAILURE = table.Column<decimal>(type: "NUMBER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SERVISES_SOCIAL_HISTORYS", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SERV_SOC_HIST_SERVISES_ID",
                        column: x => x.SERVISES_ID,
                        principalTable: "SERVISES_SOCIAL",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SERVISES_SOCIAL_PERSON_DOC",
                columns: table => new
                {
                    ID = table.Column<decimal>(type: "NUMBER", nullable: false),
                    SERVISES_ID = table.Column<decimal>(type: "NUMBER", nullable: true),
                    PERSONS_DOC_ID = table.Column<decimal>(type: "NUMBER", nullable: true),
                    DATE_INSERT = table.Column<DateTime>(type: "DATE", nullable: false, defaultValueSql: "sysdate "),
                    DATE_UPDATE = table.Column<DateTime>(type: "DATE", nullable: false, defaultValueSql: "sysdate "),
                    ID_USER = table.Column<decimal>(type: "NUMBER", nullable: true),
                    VERSION = table.Column<decimal>(type: "NUMBER", nullable: false, defaultValueSql: "0 "),
                    ID_TYPE_DOC = table.Column<decimal>(type: "NUMBER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SERVISES_SOCIAL_PERSON_DOC", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SERV_SOC_PERS_DOC_SERVISE",
                        column: x => x.SERVISES_ID,
                        principalTable: "SERVISES_SOCIAL",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "PK_EVENT_SOC_SESSION_ID",
                table: "EVENT_SOCIAL_SESSION",
                column: "ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EVENT_SOCIAL_SESSION_SESSION_ID",
                table: "EVENT_SOCIAL_SESSION",
                column: "SESSION_ID");

            migrationBuilder.CreateIndex(
                name: "PK_JI_SERVICE_SOC_ID",
                table: "JOURNAL_INTERDEPART_SERV_SOCIA",
                column: "ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_JOURNAL_INTERDEPART_SERV_SOCIA_ID_JI_REST",
                table: "JOURNAL_INTERDEPART_SERV_SOCIA",
                column: "ID_JI_REST");

            migrationBuilder.CreateIndex(
                name: "IX_JOURNAL_INTERDEPART_SERV_SOCIA_ID_SERVICE",
                table: "JOURNAL_INTERDEPART_SERV_SOCIA",
                column: "ID_SERVICE");

            migrationBuilder.CreateIndex(
                name: "PK_JL_INTERDEPART_SOC_ID",
                table: "JOURNAL_INTERDEPART_SOCIAL",
                column: "ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UK_JL_INTERDEPART_SOC_NUM",
                table: "JOURNAL_INTERDEPART_SOCIAL",
                column: "JOURNAL_NUMBER",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "I_PERSON_REST2_TEMP",
                table: "PERSONS_SOCIAL",
                columns: new[] { "PERSON_ID", "SNILS", "SEX" });

            migrationBuilder.CreateIndex(
                name: "I_PERSON_REST2_BDATE_FIO",
                table: "PERSONS_SOCIAL",
                columns: new[] { "BDATE", "SURNAME", "NAME", "PATRONYMIC" });

            migrationBuilder.CreateIndex(
                name: "PK_PERSONS_SOC_DOC_ID",
                table: "PERSONS_SOCIAL_DOC",
                column: "ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "I_PERSON_REST2_DOC_PERS_ID",
                table: "PERSONS_SOCIAL_DOC",
                column: "PERSON_ID");

            migrationBuilder.CreateIndex(
                name: "I_PERSON_REST2_DOC_TYPE_DOC_ID",
                table: "PERSONS_SOCIAL_DOC",
                column: "TYPE_DOC_ID");

            migrationBuilder.CreateIndex(
                name: "I_PERSON_REST2_DOC_TEMP",
                table: "PERSONS_SOCIAL_DOC",
                columns: new[] { "PERSON_ID", "TYPE_DOC_ID", "DATE_INSERT" });

            migrationBuilder.CreateIndex(
                name: "PK_PERSONS_SOC_DOC_FILE_ID",
                table: "PERSONS_SOCIAL_DOC_FILE",
                column: "ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PERSONS_SOCIAL_DOC_FILE_ID_PERSONS_DOC",
                table: "PERSONS_SOCIAL_DOC_FILE",
                column: "ID_PERSONS_DOC");

            migrationBuilder.CreateIndex(
                name: "PK_PERSON_SOC_LEGAL_REPRESENT",
                table: "PERSONS_SOCIAL_LEGAL_REPRESENT",
                column: "ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PERSONS_SOCIAL_LEGAL_REPRESENT_ID_LEGAL_REPRESENT",
                table: "PERSONS_SOCIAL_LEGAL_REPRESENT",
                column: "ID_LEGAL_REPRESENT");

            migrationBuilder.CreateIndex(
                name: "IX_PERSONS_SOCIAL_LEGAL_REPRESENT_ID_PERSON",
                table: "PERSONS_SOCIAL_LEGAL_REPRESENT",
                column: "ID_PERSON");

            migrationBuilder.CreateIndex(
                name: "PK_PERSON_SOC_REPRESENT",
                table: "PERSONS_SOCIAL_REPRESENT",
                column: "ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PERSONS_SOCIAL_REPRESENT_ID_PERSON",
                table: "PERSONS_SOCIAL_REPRESENT",
                column: "ID_PERSON");

            migrationBuilder.CreateIndex(
                name: "IX_PERSONS_SOCIAL_REPRESENT_ID_REPRESENT",
                table: "PERSONS_SOCIAL_REPRESENT",
                column: "ID_REPRESENT");

            migrationBuilder.CreateIndex(
                name: "SCHOOL_PK",
                table: "SCHOOL",
                column: "ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "SCHOOL_UK",
                table: "SCHOOL",
                column: "NAME",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "PK_SERVISES_INV_ID",
                table: "SERVISES_SOCIAL",
                column: "ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SERVISES_SOCIAL_ID_CURR_LEGAL_REPRESENT",
                table: "SERVISES_SOCIAL",
                column: "ID_CURR_LEGAL_REPRESENT");

            migrationBuilder.CreateIndex(
                name: "IX_SERVISES_SOCIAL_ID_CURR_REPRESENT",
                table: "SERVISES_SOCIAL",
                column: "ID_CURR_REPRESENT");

            migrationBuilder.CreateIndex(
                name: "IX_SERVISES_SOCIAL_ID_SERVICE_HISTORYS",
                table: "SERVISES_SOCIAL",
                column: "ID_SERVICE_HISTORYS");

            migrationBuilder.CreateIndex(
                name: "IX_SERVISES_SOCIAL_PERSON_ID",
                table: "SERVISES_SOCIAL",
                column: "PERSON_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SERVISES_SOCIAL_SESSION_ID",
                table: "SERVISES_SOCIAL",
                column: "SESSION_ID");

            migrationBuilder.CreateIndex(
                name: "PK_SERVISES_INV_DOC_ID",
                table: "SERVISES_SOCIAL_DOC",
                column: "ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SERVISES_SOCIAL_DOC_SERVISES_ID",
                table: "SERVISES_SOCIAL_DOC",
                column: "SERVISES_ID");

            migrationBuilder.CreateIndex(
                name: "PK_SERVIS_SOC_FAMILY_CAT_ID",
                table: "SERVISES_SOCIAL_FAMILY_CAT",
                column: "ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SERVISES_SOCIAL_FAMILY_CAT_SERVISES_SOCIAL_ID",
                table: "SERVISES_SOCIAL_FAMILY_CAT",
                column: "SERVISES_SOCIAL_ID");

            migrationBuilder.CreateIndex(
                name: "PK_SERV_SOC_HIST_ID",
                table: "SERVISES_SOCIAL_HISTORYS",
                column: "ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SERVISES_SOCIAL_HISTORYS_SERVISES_ID",
                table: "SERVISES_SOCIAL_HISTORYS",
                column: "SERVISES_ID");

            migrationBuilder.CreateIndex(
                name: "PK_SERV_SOC_PERSON_DOC_ID",
                table: "SERVISES_SOCIAL_PERSON_DOC",
                column: "ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SERVISES_SOCIAL_PERSON_DOC_SERVISES_ID",
                table: "SERVISES_SOCIAL_PERSON_DOC",
                column: "SERVISES_ID");

            migrationBuilder.CreateIndex(
                name: "PK_SOC_DELIVERY_ID",
                table: "SOCIAL_DELIVERY",
                column: "ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SOCIAL_DELIVERY_SOCIAL_SESSION_ID",
                table: "SOCIAL_DELIVERY",
                column: "SOCIAL_SESSION_ID");

            migrationBuilder.CreateIndex(
                name: "PK_SOC_PERIOD_ID",
                table: "SOCIAL_PERIOD",
                column: "ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "PK_SOC_PLACE_ID",
                table: "SOCIAL_PLACE",
                column: "ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SOCIAL_PLACE_SOCIAL_WAY_ID",
                table: "SOCIAL_PLACE",
                column: "SOCIAL_WAY_ID");

            migrationBuilder.CreateIndex(
                name: "PK_SOC_SESSION_ID",
                table: "SOCIAL_SESSION",
                column: "ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SOCIAL_SESSION_ID_EVENT_SESSION",
                table: "SOCIAL_SESSION",
                column: "ID_EVENT_SESSION");

            migrationBuilder.CreateIndex(
                name: "IX_SOCIAL_SESSION_SOCIAL_PLACE_ID",
                table: "SOCIAL_SESSION",
                column: "SOCIAL_PLACE_ID");

            migrationBuilder.CreateIndex(
                name: "PK_SOC_WAY_ID",
                table: "SOCIAL_WAY",
                column: "ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SOCIAL_WAY_SOCIAL_PERIOD_ID",
                table: "SOCIAL_WAY",
                column: "SOCIAL_PERIOD_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_SOC_SESSION_EVENT_ID",
                table: "SOCIAL_SESSION",
                column: "ID_EVENT_SESSION",
                principalTable: "EVENT_SOCIAL_SESSION",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JI_SERVICE_SOC_SERVICE_ID",
                table: "JOURNAL_INTERDEPART_SERV_SOCIA",
                column: "ID_SERVICE",
                principalTable: "SERVISES_SOCIAL",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SERVISES_INV_HISTORY_ID",
                table: "SERVISES_SOCIAL",
                column: "ID_SERVICE_HISTORYS",
                principalTable: "SERVISES_SOCIAL_HISTORYS",
                principalColumn: "ID",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EVENT_SOC_SESSION_LIST_ID",
                table: "EVENT_SOCIAL_SESSION");

            migrationBuilder.DropForeignKey(
                name: "FK_SERVISES_INV_SESSION_ID",
                table: "SERVISES_SOCIAL");

            migrationBuilder.DropForeignKey(
                name: "FK_SERV_SOC_HIST_SERVISES_ID",
                table: "SERVISES_SOCIAL_HISTORYS");

            migrationBuilder.DropTable(
                name: "JOURNAL_INTERDEPART_SERV_SOCIA");

            migrationBuilder.DropTable(
                name: "PERSONS_SOCIAL_DOC_FILE");

            migrationBuilder.DropTable(
                name: "PERSONS_SOCIAL_LEGAL_REPRESENT");

            migrationBuilder.DropTable(
                name: "PERSONS_SOCIAL_REPRESENT");

            migrationBuilder.DropTable(
                name: "SCHOOL");

            migrationBuilder.DropTable(
                name: "SERVISES_SOCIAL_DOC");

            migrationBuilder.DropTable(
                name: "SERVISES_SOCIAL_FAMILY_CAT");

            migrationBuilder.DropTable(
                name: "SERVISES_SOCIAL_PERSON_DOC");

            migrationBuilder.DropTable(
                name: "SOCIAL_DELIVERY");

            migrationBuilder.DropTable(
                name: "TypeDocs");

            migrationBuilder.DropTable(
                name: "JOURNAL_INTERDEPART_SOCIAL");

            migrationBuilder.DropTable(
                name: "PERSONS_SOCIAL_DOC");

            migrationBuilder.DropTable(
                name: "SOCIAL_SESSION");

            migrationBuilder.DropTable(
                name: "EVENT_SOCIAL_SESSION");

            migrationBuilder.DropTable(
                name: "SOCIAL_PLACE");

            migrationBuilder.DropTable(
                name: "SOCIAL_WAY");

            migrationBuilder.DropTable(
                name: "SOCIAL_PERIOD");

            migrationBuilder.DropTable(
                name: "SERVISES_SOCIAL");

            migrationBuilder.DropTable(
                name: "PERSONS_SOCIAL");

            migrationBuilder.DropTable(
                name: "SERVISES_SOCIAL_HISTORYS");

            migrationBuilder.DropSequence(
                name: "JIS_SEQUENCE");

            migrationBuilder.DropSequence(
                name: "S_NEW_ACCESS_ROLE_ID");

            migrationBuilder.DropSequence(
                name: "S_NEW_ACCESS_USER_ID");

            migrationBuilder.DropSequence(
                name: "S_NEW_ACCOUNT_ID");

            migrationBuilder.DropSequence(
                name: "S_NEW_ADDRESS_POSTCODE_ID");

            migrationBuilder.DropSequence(
                name: "S_NEW_CATEGORY_DOC_ID");

            migrationBuilder.DropSequence(
                name: "S_NEW_JINTERDEP_NUM");

            migrationBuilder.DropSequence(
                name: "S_NEW_JIRS");

            migrationBuilder.DropSequence(
                name: "S_NEW_NAVIGATOR_ID");

            migrationBuilder.DropSequence(
                name: "S_NEW_NUM");

            migrationBuilder.DropSequence(
                name: "S_NEW_PERSON_ID");

            migrationBuilder.DropSequence(
                name: "S_NEW_PERSONS_DOC_ID");

            migrationBuilder.DropSequence(
                name: "S_NEW_PERSONS_HISTORYS_ID");

            migrationBuilder.DropSequence(
                name: "S_NEW_ROLE_OBJECTS_ID");

            migrationBuilder.DropSequence(
                name: "S_NEW_SERVISES_DOC_ID");

            migrationBuilder.DropSequence(
                name: "S_NEW_SERVISES_HISTORYS_ID");

            migrationBuilder.DropSequence(
                name: "S_NEW_SERVISES_ID");

            migrationBuilder.DropSequence(
                name: "S_NEW_SERVISES_NUM");

            migrationBuilder.DropSequence(
                name: "S_NEW_SERVISES_REST_NUM");

            migrationBuilder.DropSequence(
                name: "S_NEW_SHO_ID");

            migrationBuilder.DropSequence(
                name: "S_NEW_USER_ID");

            migrationBuilder.DropSequence(
                name: "S_NEW_ZAGS_DATA_ID");

            migrationBuilder.DropSequence(
                name: "UID_SEQUENCE");
        }
    }
}
