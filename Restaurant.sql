PGDMP     	    *                z        
   Restaurant    14.2    14.2 3    %           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false            &           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false            '           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false            (           1262    16394 
   Restaurant    DATABASE     p   CREATE DATABASE "Restaurant" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE = 'English_United States.1252';
    DROP DATABASE "Restaurant";
                postgres    false            �            1259    16410    affecter    TABLE     �   CREATE TABLE public.affecter (
    affecter_id integer NOT NULL,
    date_affect timestamp without time zone,
    num_tab integer,
    num_serv integer
);
    DROP TABLE public.affecter;
       public         heap    postgres    false            �            1259    16409    affecter_affecter_id_seq    SEQUENCE     �   CREATE SEQUENCE public.affecter_affecter_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public.affecter_affecter_id_seq;
       public          postgres    false    214            )           0    0    affecter_affecter_id_seq    SEQUENCE OWNED BY     U   ALTER SEQUENCE public.affecter_affecter_id_seq OWNED BY public.affecter.affecter_id;
          public          postgres    false    213            �            1259    16427    commande    TABLE     �   CREATE TABLE public.commande (
    num_com integer NOT NULL,
    date_com date,
    nb_pers integer,
    heure_pay character varying(30),
    mode_pay character varying(30),
    num_tab integer
);
    DROP TABLE public.commande;
       public         heap    postgres    false            �            1259    16426    commande_num_com_seq    SEQUENCE     �   CREATE SEQUENCE public.commande_num_com_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 +   DROP SEQUENCE public.commande_num_com_seq;
       public          postgres    false    216            *           0    0    commande_num_com_seq    SEQUENCE OWNED BY     M   ALTER SEQUENCE public.commande_num_com_seq OWNED BY public.commande.num_com;
          public          postgres    false    215            �            1259    16446    contient    TABLE     �   CREATE TABLE public.contient (
    id_contient integer NOT NULL,
    qte integer,
    num_com integer,
    code_plat integer
);
    DROP TABLE public.contient;
       public         heap    postgres    false            �            1259    16445    contient_id_contient_seq    SEQUENCE     �   CREATE SEQUENCE public.contient_id_contient_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public.contient_id_contient_seq;
       public          postgres    false    220            +           0    0    contient_id_contient_seq    SEQUENCE OWNED BY     U   ALTER SEQUENCE public.contient_id_contient_seq OWNED BY public.contient.id_contient;
          public          postgres    false    219            �            1259    16439    plat    TABLE     �   CREATE TABLE public.plat (
    code_plat integer NOT NULL,
    libelle character varying(30),
    type_plat character varying(30),
    prix real
);
    DROP TABLE public.plat;
       public         heap    postgres    false            �            1259    16438    plat_code_plat_seq    SEQUENCE     �   CREATE SEQUENCE public.plat_code_plat_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public.plat_code_plat_seq;
       public          postgres    false    218            ,           0    0    plat_code_plat_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public.plat_code_plat_seq OWNED BY public.plat.code_plat;
          public          postgres    false    217            �            1259    16403    serveur    TABLE     �   CREATE TABLE public.serveur (
    num_serv integer NOT NULL,
    nom character varying(20),
    prenom character varying(20)
);
    DROP TABLE public.serveur;
       public         heap    postgres    false            �            1259    16402    serveur_num_serv_seq    SEQUENCE     �   CREATE SEQUENCE public.serveur_num_serv_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 +   DROP SEQUENCE public.serveur_num_serv_seq;
       public          postgres    false    212            -           0    0    serveur_num_serv_seq    SEQUENCE OWNED BY     M   ALTER SEQUENCE public.serveur_num_serv_seq OWNED BY public.serveur.num_serv;
          public          postgres    false    211            �            1259    16396    tabler    TABLE     S   CREATE TABLE public.tabler (
    num_tab integer NOT NULL,
    nb_place integer
);
    DROP TABLE public.tabler;
       public         heap    postgres    false            �            1259    16395    tabler_num_tab_seq    SEQUENCE     �   CREATE SEQUENCE public.tabler_num_tab_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public.tabler_num_tab_seq;
       public          postgres    false    210            .           0    0    tabler_num_tab_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public.tabler_num_tab_seq OWNED BY public.tabler.num_tab;
          public          postgres    false    209            w           2604    16413    affecter affecter_id    DEFAULT     |   ALTER TABLE ONLY public.affecter ALTER COLUMN affecter_id SET DEFAULT nextval('public.affecter_affecter_id_seq'::regclass);
 C   ALTER TABLE public.affecter ALTER COLUMN affecter_id DROP DEFAULT;
       public          postgres    false    214    213    214            x           2604    16430    commande num_com    DEFAULT     t   ALTER TABLE ONLY public.commande ALTER COLUMN num_com SET DEFAULT nextval('public.commande_num_com_seq'::regclass);
 ?   ALTER TABLE public.commande ALTER COLUMN num_com DROP DEFAULT;
       public          postgres    false    216    215    216            z           2604    16449    contient id_contient    DEFAULT     |   ALTER TABLE ONLY public.contient ALTER COLUMN id_contient SET DEFAULT nextval('public.contient_id_contient_seq'::regclass);
 C   ALTER TABLE public.contient ALTER COLUMN id_contient DROP DEFAULT;
       public          postgres    false    219    220    220            y           2604    16442    plat code_plat    DEFAULT     p   ALTER TABLE ONLY public.plat ALTER COLUMN code_plat SET DEFAULT nextval('public.plat_code_plat_seq'::regclass);
 =   ALTER TABLE public.plat ALTER COLUMN code_plat DROP DEFAULT;
       public          postgres    false    217    218    218            v           2604    16406    serveur num_serv    DEFAULT     t   ALTER TABLE ONLY public.serveur ALTER COLUMN num_serv SET DEFAULT nextval('public.serveur_num_serv_seq'::regclass);
 ?   ALTER TABLE public.serveur ALTER COLUMN num_serv DROP DEFAULT;
       public          postgres    false    212    211    212            u           2604    16399    tabler num_tab    DEFAULT     p   ALTER TABLE ONLY public.tabler ALTER COLUMN num_tab SET DEFAULT nextval('public.tabler_num_tab_seq'::regclass);
 =   ALTER TABLE public.tabler ALTER COLUMN num_tab DROP DEFAULT;
       public          postgres    false    209    210    210                      0    16410    affecter 
   TABLE DATA           O   COPY public.affecter (affecter_id, date_affect, num_tab, num_serv) FROM stdin;
    public          postgres    false    214   �8                 0    16427    commande 
   TABLE DATA           \   COPY public.commande (num_com, date_com, nb_pers, heure_pay, mode_pay, num_tab) FROM stdin;
    public          postgres    false    216   �8       "          0    16446    contient 
   TABLE DATA           H   COPY public.contient (id_contient, qte, num_com, code_plat) FROM stdin;
    public          postgres    false    220   �9                  0    16439    plat 
   TABLE DATA           C   COPY public.plat (code_plat, libelle, type_plat, prix) FROM stdin;
    public          postgres    false    218   *:                 0    16403    serveur 
   TABLE DATA           8   COPY public.serveur (num_serv, nom, prenom) FROM stdin;
    public          postgres    false    212   ;                 0    16396    tabler 
   TABLE DATA           3   COPY public.tabler (num_tab, nb_place) FROM stdin;
    public          postgres    false    210   �;       /           0    0    affecter_affecter_id_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public.affecter_affecter_id_seq', 44, true);
          public          postgres    false    213            0           0    0    commande_num_com_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public.commande_num_com_seq', 15, true);
          public          postgres    false    215            1           0    0    contient_id_contient_seq    SEQUENCE SET     G   SELECT pg_catalog.setval('public.contient_id_contient_seq', 27, true);
          public          postgres    false    219            2           0    0    plat_code_plat_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public.plat_code_plat_seq', 22, true);
          public          postgres    false    217            3           0    0    serveur_num_serv_seq    SEQUENCE SET     C   SELECT pg_catalog.setval('public.serveur_num_serv_seq', 14, true);
          public          postgres    false    211            4           0    0    tabler_num_tab_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public.tabler_num_tab_seq', 21, true);
          public          postgres    false    209            �           2606    16415    affecter affecter_pkey 
   CONSTRAINT     ]   ALTER TABLE ONLY public.affecter
    ADD CONSTRAINT affecter_pkey PRIMARY KEY (affecter_id);
 @   ALTER TABLE ONLY public.affecter DROP CONSTRAINT affecter_pkey;
       public            postgres    false    214            �           2606    16432    commande commande_pkey 
   CONSTRAINT     Y   ALTER TABLE ONLY public.commande
    ADD CONSTRAINT commande_pkey PRIMARY KEY (num_com);
 @   ALTER TABLE ONLY public.commande DROP CONSTRAINT commande_pkey;
       public            postgres    false    216            �           2606    16451    contient contient_pkey 
   CONSTRAINT     ]   ALTER TABLE ONLY public.contient
    ADD CONSTRAINT contient_pkey PRIMARY KEY (id_contient);
 @   ALTER TABLE ONLY public.contient DROP CONSTRAINT contient_pkey;
       public            postgres    false    220            �           2606    16444    plat plat_pkey 
   CONSTRAINT     S   ALTER TABLE ONLY public.plat
    ADD CONSTRAINT plat_pkey PRIMARY KEY (code_plat);
 8   ALTER TABLE ONLY public.plat DROP CONSTRAINT plat_pkey;
       public            postgres    false    218            ~           2606    16408    serveur serveur_pkey 
   CONSTRAINT     X   ALTER TABLE ONLY public.serveur
    ADD CONSTRAINT serveur_pkey PRIMARY KEY (num_serv);
 >   ALTER TABLE ONLY public.serveur DROP CONSTRAINT serveur_pkey;
       public            postgres    false    212            |           2606    16401    tabler tabler_pkey 
   CONSTRAINT     U   ALTER TABLE ONLY public.tabler
    ADD CONSTRAINT tabler_pkey PRIMARY KEY (num_tab);
 <   ALTER TABLE ONLY public.tabler DROP CONSTRAINT tabler_pkey;
       public            postgres    false    210            �           2606    16421    affecter affecter_num_serv_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.affecter
    ADD CONSTRAINT affecter_num_serv_fkey FOREIGN KEY (num_serv) REFERENCES public.serveur(num_serv);
 I   ALTER TABLE ONLY public.affecter DROP CONSTRAINT affecter_num_serv_fkey;
       public          postgres    false    212    3198    214            �           2606    16416    affecter affecter_num_tab_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.affecter
    ADD CONSTRAINT affecter_num_tab_fkey FOREIGN KEY (num_tab) REFERENCES public.tabler(num_tab);
 H   ALTER TABLE ONLY public.affecter DROP CONSTRAINT affecter_num_tab_fkey;
       public          postgres    false    214    3196    210            �           2606    16433    commande commande_num_tab_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.commande
    ADD CONSTRAINT commande_num_tab_fkey FOREIGN KEY (num_tab) REFERENCES public.tabler(num_tab);
 H   ALTER TABLE ONLY public.commande DROP CONSTRAINT commande_num_tab_fkey;
       public          postgres    false    3196    216    210            �           2606    16457     contient contient_code_plat_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.contient
    ADD CONSTRAINT contient_code_plat_fkey FOREIGN KEY (code_plat) REFERENCES public.plat(code_plat);
 J   ALTER TABLE ONLY public.contient DROP CONSTRAINT contient_code_plat_fkey;
       public          postgres    false    3204    220    218            �           2606    16452    contient contient_num_com_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.contient
    ADD CONSTRAINT contient_num_com_fkey FOREIGN KEY (num_com) REFERENCES public.commande(num_com);
 H   ALTER TABLE ONLY public.contient DROP CONSTRAINT contient_num_com_fkey;
       public          postgres    false    220    3202    216               I   x�}��� ��=E�#��f��st��}�%�U#�D]�Mͬ���!l:����a$���(��(��$�q%?         �   x�eб�0�����z���=[�q��R��b�)b����d$d���-�$�KcK�����=1ɕ�� ���8���.d�wp�<��\]��jt���Kt;|��^�K��ۜ���&`�j3�0��[_Q�=_�hZ�'4�'�M�/z��/OW>�D��vi�      "   �   x�-��� C��0'B�t�9Ά
!��� ��"�h@�e[H������t������V]�KRf�CF��C���n�
����ս��[tຐJܶ��=����gq.Jb\W�t9O�4����tP]����%�"6          �   x�u�MN�0��3��	��[��R�dc¨�u2VƖ�R��Ű	����l������r
�^I���>�$�"�j��4��i��k�푔Mjpq��Dh�_��9�/���K��x�`�o����Q��M�֗xN��t�h�^��t���=��x��1zN2�F�\0��thj��������\�u���1��E���#�����{��u��7��	Y���         s   x�Ȼ
1���W�����U��vL��&�p�ޔ�lpv��5�%qV�⥎߀�3��0Ь4��q�=5G��Y'9�IR�#����:�5f�	����V�g1�{-"�%b             x�3�4�2�4�2�4�2bS 6�c���� 5s�     