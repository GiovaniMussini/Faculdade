package uscs;

public class Node {
	int item;
	Node next;


	public Node() {
		this.item = 0;
		this.next = null;
	}
	public Node(int item) {
		this.item = item;
		this.next = null;
	}


	public void imprimeLista() {
		Node no_trab = this;
		while (no_trab != null) {
			System.out.println(" " + no_trab.item);
			no_trab = no_trab.next;
		}
		System.out.println("");
	}


	public void insertItem(int item) {
		Node no_trab = new Node(item);
		no_trab.next = this.next;
		this.next = no_trab;
	}
	public void deleteProximoItem() {
		if(this.next == null) {
			System.out.println("Impossível deletar");
		}
		else
			this.next = this.next.next;
	}
	public void alteraItem(int item) {
		this.item = item;
	}
	
	public static void main(String[] args) {
		Node n1 = new Node(8);
		Node n2 = new Node(5);
		Node n3 = new Node(9);
		
		n1.next = n2;
		n2.next = n3;
		n1.imprimeLista();
		n1.deleteProximoItem();
		n3.insertItem(12);
		n1.imprimeLista();
	}
}
