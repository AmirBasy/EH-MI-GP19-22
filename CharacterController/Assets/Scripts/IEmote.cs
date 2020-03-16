
// Una interfaccia è un contratto tra le parte: se una classe implementa una interfaccia
// deve assolutamente implementare tutti i metodi dichiarti nell'interfaccia stessa
public interface IEmote
{
    // Questa interfaccia deve avere due metodi: show normal e show Emote

    // mostra il personaggio nello stato normale
    void ShowNormal();
    
    // mostra il personaggio nello stato emote
    void ShowEmote();

}
