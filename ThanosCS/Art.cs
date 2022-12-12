namespace ThanosCS;

// Art taken from http://www.asciify.net/ascii/show/10495

public static class Art
{
    public static void RenderThanos()
    {
        Console.Write(""""
                                                                                                            
                                            `.,:::,.`                                           
                                       .,iznnnxMMMxxnnzi,`                                      
                                    `;#xWWWWWWMMMWMMWWWWMn+:`                                   
                                  .*xWWWWWMMxnnzzznnxMWWWWMMni`                                 
                                .+xWWWWMx#*i;::,:,,:;i*#nMWWWMni`                               
                              `ixWWWMx#i;:::,:,,,,,:::,,:*zxMWWWn:                              
                             .#WWWMn*;:,,:::,:,,,,,,,:,,,,::+nMWWW+.                            
                            ;nWWWx*;:::,::::::,,,:,,,:,,,::,:;+xMWWn:                           
                          `iMWWMz;,::::,::::::::,:::,:,:,::,:::;#MWWx;                          
                         `*MWMni;::::::,:::::::::::,::,,,,:,::::,*xWWM*                         
                        `+MWMz;:::::::::::,::::::::,::,,::::::::;;;nWWM*`                       
                       `+MMM+,:,:::::::,:::::::,,::::,,,:::::,::;:::#WWW*                       
                      `*WWM+,::,::,::::,:::::,:,:::::::,:::,::::::;,.#WWWi                      
                      ;MWM+.,::::,:::::,::,:::::::::::,,:::::::,,:;:,,#WWx,                     
                     .xWW#.,:::;::::::,:::,,::::,:::::,:,,:::,,,,;:::,,zWWn`                    
                     *WWn..,:::;::::::,:::,,::,,,:::::,:,.:,:::,::::::.,xWM;                    
                    `nWM;`,:,::::,:,::,::,,,:,,,,:::::::,,,,,::::::::,,`iMM#`                   
                    `MWn..:,,::,:::::::::,::::,,::::::::,,,,::::::::,,:`,xMx.                   
                    ,WW#`,::,:,,:::;::::,:,,:,,,,:;:::,,,,,,::,,::,::::.`nWM.                   
                    iWW*`,::::,,:;+##+*;::,,:,,,:::::,,,:;*+#++:::;::::.`#WM,                   
                    +WW*`,::::,::*WWWWMxxz#*;;,,:::;i*#zxMMWWWMi:;;;;::.`#WW:                   
                    #WWn,,:,:,:::;MWWWWWWWWMMxz##znxMMMMWMWMWWMi;;;::::.:xWWi                   
                    #WWW#,::::::::zzzznxMWMMWWWMMWWWWWMMMxnz#z#;;;;:::::nWWW#                   
                    #WWWMi:;:::::,:::::;*+zxxMMMWWMMMx#+*;:::::::::;;;:+WWWWz                   
                   `zWMWWz::::::::::::::::,:;i*##+*i;:,,:,,,:::::;;;::;nWWWWz                   
                   `nWMWWn;:::::i*##+*i;;::,,,,::,,::::,:;i*++**;:::::iMWWWWz                   
                   .xWWWWx;,::::+MWWWWMxxz+i;:::::::i*#znxMWWWWM*:::::iMWWMWn`                  
                   ,MWWWWx;,,:::*WWWWWWWWWWMxnnz#zznMWWWWWWWWWWM*:::::*WWMMMn`                  
                   ,WWMMWx;,,:::;nnzznxMWWWMMWWWWWWWWWWWMMxnzznz;:::::*WWxxWx,                  
                   ,WWMMWx;:,,:::;::::;;*+zxxMMWWWMMxxz+*;;::::::;::,:*WWxnMx,                  
                   :WWxMWx;::,:::,:::::::,::i*+###+*i;:,::,:::,:::::,:*WWxnWM:                  
                   :WWnxWM;::,::::::::,::,,::,,,::::,,:,,:::::::::;:,:iWWnzWM:                  
                   ;WWzxWx;,,,::::,,:,:,,::::,,,,:,,:,:::::::::;:::::,iWWn#MM;                  
                   iWW#xWx;,,,:,:,:::,:::::::,,:,::::::::::,,:::::,:::iWWn#MM;                  
                   #WM+xWx;::,,,:,,::,,::::::,:,,::::,:::::,::::::::::*WWn+WWi                  
                   zWM*xWx;::,,,:::::,,,:::::,:,,::::,,:::,,::::::::::*WWn*WW*                  
                   nWMixWx;,,:,:,:,::,,,::,::,:,,:::::,:::,,::::::::::*WWniMW+                  
                   nWMixWx;:,,,,,,,::,::,:::,,:,,::::,:::::,,:::::,::,iWWn;MM#                  
               .` `xWM;nxn::,,,:,,:::::::::::;;;:;;;;,,::::,,:::::,:,,iMMz:MMn `.`              
             ,znn+;xWx,,;:,:,,:i#z#+i::::::,;xxz;#xx+,,,::::;*#zz+;;:::i:,,MWx:zxn+`            
            .xWMWWMMWx.`,,:::inMWWWWMn#i;:,:iMWx;zWM+,,::;+zxWWWWWM#;:,,.`.MWMMMMMMz            
            ;WWMMWWWWn.`,::;+MWMWWWWWWWMx#*;iMWx;zWW+:i#nMWWWWWWWWWMz:,,,``MWMMWxMMx.           
            iWW#*MWWWz.`::;#MWWMWWWWWWWWWWMxxWWn;#WWxxMWWWWWWWWWWWWWWz::,``xWWWx;nMM,           
            iWW+`+MWW#.`::+MWWMMWWWWWMWWWWWWWWW#:*MWWWWWWWWWWWWWWWWWWM#:,``nWWMi.zMM:           
            iWW+`.zWW#``:*MWWWWMWWWWWMWWMMxWWMz;::+MMWxMMWWWWWWWWWWWWWM+,``nMM+`.zWM:           
            *WW+``+WW+`.:ixWMMMxnWWWWWMMM+;**i:::::i**iixWWWWWWWxnMMxMM+:``zWMi`.zWM:           
            *WW+``+WW*`.::in*iiiixWWWWznz;;*++;:::i++*::+xzMWWWM+;iiin*::``#WW*`.nWM:           
            *WW+``#WWi`.:,:::::::izxn+;:;::zWM+:::#WMz:::;:*nxn*:::::::,:``+WW*`.nWM:           
            *WW+``zWMi`.:,::::::::;;:::::::nWM+:::+WWz::,:::;;;::::,:,,::``+WW+`.nWM:           
            *WW+``nWMi`.::,:::::::::,::::::zWM+,::+WWz;:,,::;::::,:::,::,``*MW#`.nWM:           
            iWW+``xWMz..::::::::::::,::::::zWM+:::+WWz:::::::::::,:::::::.`zWWz..nMM:           
            iWW+`.MWWM,,:::::::::::::::::::nWM+:::#WWz:::::;:::::,,:::::,.,MWWn..zMM:           
            iWW+`.MWWW*,:::::::::::::,:::izMWM*:::#WWMzi::::;:,:;::::,:::.*WWWn..zMM:           
            iWW+`,MWWWn:::;:::::::::::::;xMWWM*:::+MWWWx;::::;:::::,,:::::nWWWx..zMM:           
            ;WW#`:MWWWM*:;;;:;::::::::::iMWMni:::::*xWWM;:::::;;::::,::::iMWWWx,.nMM:           
            :MWx,:WWWWWz;:::;;::::i;,:::iMWWni;:,:;*nWWM;:::;;;::;::,::::zWWWWM,:MWx.           
            `nWW*iWWMWWx:::::;:::ix#::::iMWWWMn+;+xWWWWM;:;:;+x+;:::::::;xWWWWW:zWW#            
             ;WWMzWWnMWMi:::::::;nWWz::;;+nWWWWMMMWWWMn*:;;:+MWMi::;:::,iMWMMWWzMWx,            
             `zWWWWW#nWW+:::::::#WWM+::;::;+nMWWWWWMz*::::;:*MWWn:::::::+WWnnWWMMMi             
              ,MWWWW+#WW#::;:::*MWM#:::::::;;izMWM#*::::::::;#WWW#::::::#WW+zWWMMz`             
               iMWWW**WWz:::::ixWWn;::::::::::;i*;::::::::;::izWWMi:::::nWM*#WWWx,              
               `zWWWiiWWn;;::;nWWMi:;:::::::::::::::::,::;:::;;nWWx;::::nWMi+WWWi               
                ,xWWiiWWn::::#WWM+:::::::,::::::;:::::,,:::::;:iMWMz::::nWW;*WWn`               
                `zWM;iMWn:::+MWWz:::,:::::::;;;::::::,,:::;:;;::+MWW#:::xWW;iWW#                
                `nWM:iMWn;:iMWWni:::::::;;;;i;:::::;;;;;:;;;;;;;;zWWM*::xWM;;WW#                
                .xWM:iWWz::zWWMi;::;;:i#xxxxxn+;;;+nxMMxn#i;ii;;;ixWWn::nWM;:WWz                
                .xWx,iWWn;;zWWz;;;::;+MWWWWWWWMxnxMWWWWWWWxi;;;;;;+WWn;:nWW;:MWz`               
                ,MWx.iWWn;;zWW#;;;;;+MWWWMMMMWWWWWWWMMMMMWWM+;;;;;+WWn;:nWW;,MWn`               
                ,WWx.iWWn;;zWW#:;;i#MWWM+i*i*zMMWWx#*ii*#MWWM+:;:;+WMn;;nWW;,xWx.               
                ,WWn`iWWn:;zWW#:*MMWWWx*::::::;i*i;::::;;+MWWWMx*;+WWn;;xWM;,xWM,               
                ,WWz`iWWn:;zWWz;+WWWWx*;:::::;:,,:::::::;;*MWWWWi:*WWn:;nWW;.nWW:               
                :WW#`:#z+::*zz*:*MMMx+i;:::::::::::::::::;i+xMWMi:i#z#;:+z#,.nWW:               
                ;WW+``:;:::::::::iiiinxi::::::,,,::::::::ixni*i*;::::;;::;,``zWW:               
                iWW*``::::::::::i;::zWWxi;;;;;::;:;;;:::ixWWz;:i*;:::;:::;,``#WW:               
                *WWi``:::;:::::+Mn*;nWWWxnnnnnnnnnnxxnnnxWWWz;*nM+;;::::::,``+WW;               
                +WW;``::::::::;xWW#:zWWWWWWWWWWWWWWWWWWWMWWW#;nWWn;::;:::::``+WW;               
                +WWi``::::::;;+WWW*;zWWWWWWWWWWWWWWWWWWWWWWW+:+WWM*::;:::::``+WW;               
                *WW*`.:::::::ixWWM*:zWWz+zWWx*#MWM++xWWz+nWW#:+WWWn;:;:;:::``#WW:               
                :WWz`.:::::::+MWWM*:zWW#;+WWn,iMWM;;nWW+:zWW#:#WWWM*:;:::,:`.nWM:               
                .MWx:.:::;::;nWWWW*:zWW#;+WWn:iMWM;;xWM*:zWW#:+WWWWn;:;::::`:MWn`               
                `zWW*`:::;::*MWWWW*;zWW#;+WWz:iMWxi;xWW+:zWW+:+MWWWM*:;:,:,`+WW#                
                 iWWn.,:::::nWWWWM*;zWW+:+MWz:;MWxi;xWM+:zWM#:#WWWWWz;;:::.,xWM:                
                 `xWM;,;:::*MWWWWW*;zWW+:+MWz,iMWx;;xWM*;zMM#:+WWMWWM*::::.*MWn`                
                  *WWz,;;;;nWWnMWW*;zWW+:+WWn,iMWM:;xWM*:zWM+:+WWnxWWz;::,.nWWi                 
                  .MWW;,;;*WWM*xWW*:#WW+:+WWn:iMWM;;xWM*:zWM+:+WWz+MWx;::,iMWx`                 
                   +WWn,;;#WWxixWW+;#MW+:+WWn:iMWM;;xWM*:zWW+:+MWz;xWM*:::xWWi                  
                   .xWW*:;nWW#;xWW*;zWW#;+WWn:iMWM;;xWM*:zWM#:+WWz:nWW#,:+WWn.                  
                    iWWM;;nWW*:xWMi;zWW#;*WWn:iMWx;;xWM*:zWM#:+WWz:#WWz:;MWW;                   
                    `nWWnixWM*:xWMi:zWW+:+WWn:*MWM;;nWM*:zWM#:+WWz:+WWn;xWM#`                   
                     ,MWW#xWM*:xWM*:zWW+:+WWn:*MWM;;nWM*:zWM+:#WWz:+WWnzWWx.                    
                      *WWMMWW+:xWW*:zWW#:+WWz,iMWM;;xWM*:zWW+:#WWz:#WWMMWM:                     
                      `#WWWWWz:xWW*:#WW+,+WWn,iMWM;;xWM*:zWW+:#WWz;nWWWWWi                      
                       .nWWWWxixWW*:#WW+:*WWn:iMWM;;xWM*:zWW+:#WWziMWWWW+`                      
                        ,xWWWW#xWW*:#WW+:*WWn;iMWM;;xWMi:zWW#:+MWz#WWWW#`                       
                         ,MWWWMMWM*:#WW+:*WWn:iMWM;;nWMi:zWW#:+WWxMWWW#`                        
                          :MWWWWWW*:zWW#:+WWn:iMWM;;nWMi:zWW+:+WWMWWW#`                         
                           :xWWWWW*:zWW+:+WWn:;MWx;;nWMi:zWW+,+WWWWW#`                          
                            ,xWWWW+;zWW+:+WWn:iMWx::nWM*:zWW+:+WWWW+`                           
                             .zWWWMzxWW#:+WWn;*MWx;;xWW*:zWWzzMWWM*`                            
                              `*MWWWWWWxnxWWMnnMWMnnMWWxnMWWWWWWx;                              
                                ,zWWWWWWWWWWWWMMWWWWWWWWWWWWWWM+.                               
                                 `,+znxMMMMWMWWMMWWWMMMMxxnzz*.                                 
                                     `.,,,:::::::::::,,,,..`                                    

                                                                                                
            """");
        Console.WriteLine();
    }

    public static void RenderSnap()
    {
        Console.Write("""
                                                                    iz`                                     
                                                 .nWx:            .i+nni`                  
                                         ,;     :Wx;i+          .zWMn#n@+                  
                                        :Mn   `*Wz:::n`        :Mzi::::*W,                 
                                       ;Wzn` `#@+::::#;       ;x;:::::::n;                 
                                      :Wz:+: iWi:::::iz      ix;::::::::*+                 
                      `;zx`        . .Wz::** **:::::::z`    ix;:::::::::*z                 
                     ,nn+n;       in .x:::;# i*:::::::+;   ;x;::::::::::;z                 
                    ini::i#      ;Wx. z::::n`i*:::::::;z  .n;::::::;::::;z                 
                   +z:::::n`    ,W++i +;:::n.;*:::#::::n. #*:::::ixWi:::;#                 
                  ++::::::z,   `xz:;# ;*:::z,;+:::W;:::*i zi::::iM#++:::ii                 
                 *+:::::::*i   zx:::n..#:::#;;+:::M+:::;z **:::;xi :+:::+:                 
                ;#::::::::;z  iW;:::*+`z:::i*:+:::##;:::z,:+:::*+  *i:::#,                 
               ,z::::::::;#M`.M*:::::n`#;:::#.z:::#i+:::**,z:::** `n::::z`                 
              `z;:::::::#x#: ,x::::::#:*i:::z,z:::#,z::::z.z:::;* +z:::i+                  
              **::::::;n+.   `n::::::iz:+:::+in:::#.#i:::z:n:::;+;x::::#:                  
             .n::::::;n:      #;::::::z,z:::i+z:::#,:#:::i+#;:::MM;:::;z                   
             **:::::;n,       *i::::::*##::::#z:::+:`z;:::z**:::+i::::#;                   
            `n::::::z:      .:z#:::::::zni:::zx:::+;.Mi:::+#+::::::::iz                    
            ,#:::::++     :zMxMz:::;+::i@*:::#W:::+*xz::::;Mz:::::::ix.                    
            **:::::x.   :zn*;:::::::M;::z#:::*W;::*@x::::::zn::::::*M:                     
            #i::::;M.`;#ni::::::::::xz:::::::;M;::ix;::::::iM;:::#Mx:                      
            n;::::;Wxxx*::::::::::::zW;:::::::;::::::::;::::x*:::zi`                       
            n;:::::i*i::::::::::::::*@z:::::::::::::::;M+:::i;:::+,                        
            n;::::::::::::::::::::::;zni:::::::::::::;Mzn::::::::*i                        
            n;::::::::::;::::::::;:::z:n::::::i*::::;Mz`z:::**:::;+                        
            ni::::::::inWx::::::*n:::#.zi::::iWx::::M#` +i:+Wx::::#                        
            #z::::::;zn;,M::::::zx:::#:,z:::iWzn:::iz`  ,#+W;#;:::#`                       
            ,W#:::;#xi` .x::::::nz;::*+ #*:iWn`z:::;+   `xWi +*:::#.                       
             :MWMMxi`   ++:::::***i::;z ,n;Mz` +;::;+    #;  ;+:::+;                       
              `;i:`    ;n::::::n.;*:::n` #Mx`  *i::;z        .z:::*+                       
                     `*n;:::::zi ,z::;M` .x.   ;+:iMz        `n::;xn                       
                   .*x#::::::++  `n:iMn`       :#zWz`         #;iMx.                       
                   zn*::::::+#    ziMn.        .WM*           *#Wn`                        
                   ;+::::::+z`    *Mn`         `#.            ;@#`                         
                   `z:::::#+`     :M.                         `;                           
                    +*::ix*        `                                                       
                    ,xnnn:                                                                 
                     ++;`                                                                  
            """);
        Console.WriteLine();
    }
}