u s i n g   S y s t e m ;  
 u s i n g   U n i t y E n g i n e ;  
 u s i n g   U n i t y E n g i n e . E v e n t S y s t e m s ;  
  
 n a m e s p a c e   U n i t y S t a n d a r d A s s e t s . C r o s s P l a t f o r m I n p u t  
 {  
 	 p u b l i c   c l a s s   J o y s t i c k   :   M o n o B e h a v i o u r ,   I P o i n t e r D o w n H a n d l e r ,   I P o i n t e r U p H a n d l e r ,   I D r a g H a n d l e r  
 	 {  
 	 	 p u b l i c   e n u m   A x i s O p t i o n  
 	 	 {  
 	 	 	 / /   O p t i o n s   f o r   w h i c h   a x e s   t o   u s e  
 	 	 	 B o t h ,   / /   U s e   b o t h  
 	 	 	 O n l y H o r i z o n t a l ,   / /   O n l y   h o r i z o n t a l  
 	 	 	 O n l y V e r t i c a l   / /   O n l y   v e r t i c a l  
 	 	 }  
  
 	 	 p u b l i c   i n t   M o v e m e n t R a n g e   =   1 0 0 ;  
 	 	 p u b l i c   A x i s O p t i o n   a x e s T o U s e   =   A x i s O p t i o n . B o t h ;   / /   T h e   o p t i o n s   f o r   t h e   a x e s   t h a t   t h e   s t i l l   w i l l   u s e  
 	 	 p u b l i c   s t r i n g   h o r i z o n t a l A x i s N a m e   =   " H o r i z o n t a l " ;   / /   T h e   n a m e   g i v e n   t o   t h e   h o r i z o n t a l   a x i s   f o r   t h e   c r o s s   p l a t f o r m   i n p u t  
 	 	 p u b l i c   s t r i n g   v e r t i c a l A x i s N a m e   =   " V e r t i c a l " ;   / /   T h e   n a m e   g i v e n   t o   t h e   v e r t i c a l   a x i s   f o r   t h e   c r o s s   p l a t f o r m   i n p u t  
  
 	 	 V e c t o r 3   m _ S t a r t P o s ;  
 	 	 b o o l   m _ U s e X ;   / /   T o g g l e   f o r   u s i n g   t h e   x   a x i s  
 	 	 b o o l   m _ U s e Y ;   / /   T o g g l e   f o r   u s i n g   t h e   Y   a x i s  
 	 	 C r o s s P l a t f o r m I n p u t M a n a g e r . V i r t u a l A x i s   m _ H o r i z o n t a l V i r t u a l A x i s ;   / /   R e f e r e n c e   t o   t h e   j o y s t i c k   i n   t h e   c r o s s   p l a t f o r m   i n p u t  
 	 	 C r o s s P l a t f o r m I n p u t M a n a g e r . V i r t u a l A x i s   m _ V e r t i c a l V i r t u a l A x i s ;   / /   R e f e r e n c e   t o   t h e   j o y s t i c k   i n   t h e   c r o s s   p l a t f o r m   i n p u t  
  
 	 	 v o i d   O n E n a b l e ( )  
 	 	 {  
 	 	 	 C r e a t e V i r t u a l A x e s ( ) ;  
 	 	 }  
  
                 v o i d   S t a r t ( )  
                 {  
                         m _ S t a r t P o s   =   t r a n s f o r m . p o s i t i o n ;  
                 }  
  
 	 	 v o i d   U p d a t e V i r t u a l A x e s ( V e c t o r 3   v a l u e )  
 	 	 {  
 	 	 	 v a r   d e l t a   =   m _ S t a r t P o s   -   v a l u e ;  
 	 	 	 d e l t a . y   =   - d e l t a . y ;  
 	 	 	 d e l t a   / =   M o v e m e n t R a n g e ;  
 	 	 	 i f   ( m _ U s e X )  
 	 	 	 {  
 	 	 	 	 m _ H o r i z o n t a l V i r t u a l A x i s . U p d a t e ( - d e l t a . x ) ;  
 	 	 	 }  
  
 	 	 	 i f   ( m _ U s e Y )  
 	 	 	 {  
 	 	 	 	 m _ V e r t i c a l V i r t u a l A x i s . U p d a t e ( d e l t a . y ) ;  
 	 	 	 }  
 	 	 }  
  
 	 	 v o i d   C r e a t e V i r t u a l A x e s ( )  
 	 	 {  
 	 	 	 / /   s e t   a x e s   t o   u s e  
 	 	 	 m _ U s e X   =   ( a x e s T o U s e   = =   A x i s O p t i o n . B o t h   | |   a x e s T o U s e   = =   A x i s O p t i o n . O n l y H o r i z o n t a l ) ;  
 	 	 	 m _ U s e Y   =   ( a x e s T o U s e   = =   A x i s O p t i o n . B o t h   | |   a x e s T o U s e   = =   A x i s O p t i o n . O n l y V e r t i c a l ) ;  
  
 	 	 	 / /   c r e a t e   n e w   a x e s   b a s e d   o n   a x e s   t o   u s e  
 	 	 	 i f   ( m _ U s e X )  
 	 	 	 {  
 	 	 	 	 m _ H o r i z o n t a l V i r t u a l A x i s   =   n e w   C r o s s P l a t f o r m I n p u t M a n a g e r . V i r t u a l A x i s ( h o r i z o n t a l A x i s N a m e ) ;  
 	 	 	 	 C r o s s P l a t f o r m I n p u t M a n a g e r . R e g i s t e r V i r t u a l A x i s ( m _ H o r i z o n t a l V i r t u a l A x i s ) ;  
 	 	 	 }  
 	 	 	 i f   ( m _ U s e Y )  
 	 	 	 {  
 	 	 	 	 m _ V e r t i c a l V i r t u a l A x i s   =   n e w   C r o s s P l a t f o r m I n p u t M a n a g e r . V i r t u a l A x i s ( v e r t i c a l A x i s N a m e ) ;  
 	 	 	 	 C r o s s P l a t f o r m I n p u t M a n a g e r . R e g i s t e r V i r t u a l A x i s ( m _ V e r t i c a l V i r t u a l A x i s ) ;  
 	 	 	 }  
 	 	 }  
  
  
 	 	 p u b l i c   v o i d   O n D r a g ( P o i n t e r E v e n t D a t a   d a t a )  
 	 	 {  
 	 	 	 V e c t o r 3   n e w P o s   =   V e c t o r 3 . z e r o ;  
  
 	 	 	 i f   ( m _ U s e X )  
 	 	 	 {  
 	 	 	 	 i n t   d e l t a   =   ( i n t ) ( d a t a . p o s i t i o n . x   -   m _ S t a r t P o s . x ) ;  
 	 	 	 	 / / d e l t a   =   M a t h f . C l a m p ( d e l t a ,   -   M o v e m e n t R a n g e ,   M o v e m e n t R a n g e ) ;  
 	 	 	 	 n e w P o s . x   =   d e l t a ;  
 	 	 	 }  
  
 	 	 	 i f   ( m _ U s e Y )  
 	 	 	 {  
 	 	 	 	 i n t   d e l t a   =   ( i n t ) ( d a t a . p o s i t i o n . y   -   m _ S t a r t P o s . y ) ;  
 	 	 	 	 / / d e l t a   =   M a t h f . C l a m p ( d e l t a ,   - M o v e m e n t R a n g e ,   M o v e m e n t R a n g e ) ;  
 	 	 	 	 n e w P o s . y   =   d e l t a ;  
 	 	 	 }  
 	 	 	 t r a n s f o r m . p o s i t i o n   =   V e c t o r 3 . C l a m p M a g n i t u d e (   n e w   V e c t o r 3 ( n e w P o s . x ,   n e w P o s . y ,   n e w P o s . z ) ,   M o v e m e n t R a n g e ) +   m _ S t a r t P o s ;  
 	 	 	 U p d a t e V i r t u a l A x e s ( t r a n s f o r m . p o s i t i o n ) ;  
 	 	 }  
  
  
 	 	 p u b l i c   v o i d   O n P o i n t e r U p ( P o i n t e r E v e n t D a t a   d a t a )  
 	 	 {  
 	 	 	 t r a n s f o r m . p o s i t i o n   =   m _ S t a r t P o s ;  
 	 	 	 U p d a t e V i r t u a l A x e s ( m _ S t a r t P o s ) ;  
 	 	 }  
  
  
 	 	 p u b l i c   v o i d   O n P o i n t e r D o w n ( P o i n t e r E v e n t D a t a   d a t a )   {   }  
  
 	 	 v o i d   O n D i s a b l e ( )  
 	 	 {  
 	 	 	 / /   r e m o v e   t h e   j o y s t i c k s   f r o m   t h e   c r o s s   p l a t f o r m   i n p u t  
 	 	 	 i f   ( m _ U s e X )  
 	 	 	 {  
 	 	 	 	 m _ H o r i z o n t a l V i r t u a l A x i s . R e m o v e ( ) ;  
 	 	 	 }  
 	 	 	 i f   ( m _ U s e Y )  
 	 	 	 {  
 	 	 	 	 m _ V e r t i c a l V i r t u a l A x i s . R e m o v e ( ) ;  
 	 	 	 }  
 	 	 }  
 	 }  
 } 