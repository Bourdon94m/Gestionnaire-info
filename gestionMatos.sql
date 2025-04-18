PGDMP  6                     }           gestion_matos    17.4    17.4 $    B           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                           false            C           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                           false            D           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                           false            E           1262    16388    gestion_matos    DATABASE     p   CREATE DATABASE gestion_matos WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'en';
    DROP DATABASE gestion_matos;
                     postgres    false            �            1259    16424    intervention    TABLE     �   CREATE TABLE public.intervention (
    intervention_id integer NOT NULL,
    planned_date date NOT NULL,
    commentary text,
    material_id integer,
    completed boolean DEFAULT false,
    staff_id integer
);
     DROP TABLE public.intervention;
       public         heap r       postgres    false            �            1259    16423     intervention_intervention_id_seq    SEQUENCE     �   CREATE SEQUENCE public.intervention_intervention_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 7   DROP SEQUENCE public.intervention_intervention_id_seq;
       public               postgres    false    224            F           0    0     intervention_intervention_id_seq    SEQUENCE OWNED BY     e   ALTER SEQUENCE public.intervention_intervention_id_seq OWNED BY public.intervention.intervention_id;
          public               postgres    false    223            �            1259    16410    material    TABLE     �   CREATE TABLE public.material (
    material_id integer NOT NULL,
    serial_number character varying(6) NOT NULL,
    mtbf integer,
    name character varying NOT NULL,
    description text,
    type character varying,
    site_id integer
);
    DROP TABLE public.material;
       public         heap r       postgres    false            �            1259    16409    material_material_id_seq    SEQUENCE     �   CREATE SEQUENCE public.material_material_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 /   DROP SEQUENCE public.material_material_id_seq;
       public               postgres    false    222            G           0    0    material_material_id_seq    SEQUENCE OWNED BY     U   ALTER SEQUENCE public.material_material_id_seq OWNED BY public.material.material_id;
          public               postgres    false    221            �            1259    16401    site    TABLE     `   CREATE TABLE public.site (
    id_site integer NOT NULL,
    name character varying NOT NULL
);
    DROP TABLE public.site;
       public         heap r       postgres    false            �            1259    16400    site_id_site_seq    SEQUENCE     �   CREATE SEQUENCE public.site_id_site_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public.site_id_site_seq;
       public               postgres    false    220            H           0    0    site_id_site_seq    SEQUENCE OWNED BY     E   ALTER SEQUENCE public.site_id_site_seq OWNED BY public.site.id_site;
          public               postgres    false    219            �            1259    16390    staff    TABLE     �   CREATE TABLE public.staff (
    staff_id integer NOT NULL,
    first_name character varying NOT NULL,
    last_name character varying NOT NULL,
    email character varying NOT NULL,
    password character varying NOT NULL
);
    DROP TABLE public.staff;
       public         heap r       postgres    false            �            1259    16389    staff_staff_id_seq    SEQUENCE     �   CREATE SEQUENCE public.staff_staff_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public.staff_staff_id_seq;
       public               postgres    false    218            I           0    0    staff_staff_id_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public.staff_staff_id_seq OWNED BY public.staff.staff_id;
          public               postgres    false    217            �           2604    16427    intervention intervention_id    DEFAULT     �   ALTER TABLE ONLY public.intervention ALTER COLUMN intervention_id SET DEFAULT nextval('public.intervention_intervention_id_seq'::regclass);
 K   ALTER TABLE public.intervention ALTER COLUMN intervention_id DROP DEFAULT;
       public               postgres    false    224    223    224            �           2604    16413    material material_id    DEFAULT     |   ALTER TABLE ONLY public.material ALTER COLUMN material_id SET DEFAULT nextval('public.material_material_id_seq'::regclass);
 C   ALTER TABLE public.material ALTER COLUMN material_id DROP DEFAULT;
       public               postgres    false    221    222    222            �           2604    16404    site id_site    DEFAULT     l   ALTER TABLE ONLY public.site ALTER COLUMN id_site SET DEFAULT nextval('public.site_id_site_seq'::regclass);
 ;   ALTER TABLE public.site ALTER COLUMN id_site DROP DEFAULT;
       public               postgres    false    219    220    220            �           2604    16393    staff staff_id    DEFAULT     p   ALTER TABLE ONLY public.staff ALTER COLUMN staff_id SET DEFAULT nextval('public.staff_staff_id_seq'::regclass);
 =   ALTER TABLE public.staff ALTER COLUMN staff_id DROP DEFAULT;
       public               postgres    false    218    217    218            ?          0    16424    intervention 
   TABLE DATA           s   COPY public.intervention (intervention_id, planned_date, commentary, material_id, completed, staff_id) FROM stdin;
    public               postgres    false    224   "*       =          0    16410    material 
   TABLE DATA           f   COPY public.material (material_id, serial_number, mtbf, name, description, type, site_id) FROM stdin;
    public               postgres    false    222   ?*       ;          0    16401    site 
   TABLE DATA           -   COPY public.site (id_site, name) FROM stdin;
    public               postgres    false    220   �*       9          0    16390    staff 
   TABLE DATA           Q   COPY public.staff (staff_id, first_name, last_name, email, password) FROM stdin;
    public               postgres    false    218   ,+       J           0    0     intervention_intervention_id_seq    SEQUENCE SET     O   SELECT pg_catalog.setval('public.intervention_intervention_id_seq', 1, false);
          public               postgres    false    223            K           0    0    material_material_id_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public.material_material_id_seq', 3, true);
          public               postgres    false    221            L           0    0    site_id_site_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public.site_id_site_seq', 1, false);
          public               postgres    false    219            M           0    0    staff_staff_id_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public.staff_staff_id_seq', 1, false);
          public               postgres    false    217            �           2606    16432    intervention intervention_pkey 
   CONSTRAINT     i   ALTER TABLE ONLY public.intervention
    ADD CONSTRAINT intervention_pkey PRIMARY KEY (intervention_id);
 H   ALTER TABLE ONLY public.intervention DROP CONSTRAINT intervention_pkey;
       public                 postgres    false    224            �           2606    16417    material material_pkey 
   CONSTRAINT     ]   ALTER TABLE ONLY public.material
    ADD CONSTRAINT material_pkey PRIMARY KEY (material_id);
 @   ALTER TABLE ONLY public.material DROP CONSTRAINT material_pkey;
       public                 postgres    false    222            �           2606    16408    site site_pkey 
   CONSTRAINT     Q   ALTER TABLE ONLY public.site
    ADD CONSTRAINT site_pkey PRIMARY KEY (id_site);
 8   ALTER TABLE ONLY public.site DROP CONSTRAINT site_pkey;
       public                 postgres    false    220            �           2606    16399    staff staff_email_key 
   CONSTRAINT     Q   ALTER TABLE ONLY public.staff
    ADD CONSTRAINT staff_email_key UNIQUE (email);
 ?   ALTER TABLE ONLY public.staff DROP CONSTRAINT staff_email_key;
       public                 postgres    false    218            �           2606    16397    staff staff_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.staff
    ADD CONSTRAINT staff_pkey PRIMARY KEY (staff_id);
 :   ALTER TABLE ONLY public.staff DROP CONSTRAINT staff_pkey;
       public                 postgres    false    218            �           2606    16433 *   intervention intervention_material_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.intervention
    ADD CONSTRAINT intervention_material_id_fkey FOREIGN KEY (material_id) REFERENCES public.material(material_id) ON DELETE CASCADE;
 T   ALTER TABLE ONLY public.intervention DROP CONSTRAINT intervention_material_id_fkey;
       public               postgres    false    224    4769    222            �           2606    16438 '   intervention intervention_staff_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.intervention
    ADD CONSTRAINT intervention_staff_id_fkey FOREIGN KEY (staff_id) REFERENCES public.staff(staff_id) ON DELETE SET NULL;
 Q   ALTER TABLE ONLY public.intervention DROP CONSTRAINT intervention_staff_id_fkey;
       public               postgres    false    218    4765    224            �           2606    16418    material material_site_id_fkey    FK CONSTRAINT     �   ALTER TABLE ONLY public.material
    ADD CONSTRAINT material_site_id_fkey FOREIGN KEY (site_id) REFERENCES public.site(id_site) ON DELETE SET NULL;
 H   ALTER TABLE ONLY public.material DROP CONSTRAINT material_site_id_fkey;
       public               postgres    false    222    4767    220            ?      x������ � �      =   �   x�E��
�0�ϛ��'k��?Zh� ��W�H�O�T��v�af>\$�l<��[�Ivئ��R�V9t�!��2�&(*[�+K���E����@1>�Vfp%�<�ք�����^*�ݿB�V�M^���|���D!��|;G�t^�� ��ꆜ�@}OQ@m����c_��A�      ;   !   x�3�H,�,�2��M,*N���I����� `(�      9   G   x�3�LL���C&�s3s���s!|.CN�����TN���*�t0[/	�vHO-.��ϋ�M,�/F����� �g�     