public class LinkedList<T> {
    private class Node<T>{
        public T Value {get;set;}
        public Node<T> Next{get;set;}
        public Node()
        {
            this.Next=null;
       
            
        }
        public Node(T value)
        {
            this.Next=null;
            this.Value=value;
            
        }
    }
    Node<T> head;
    Node<T> tail;
    int count;
    public LinkedList()
    {
        head=tail=null;
        count=0;
    }
    public void InsertFirst(T value){
        Node<T> newNode=new Node<T>(value);
        if(count==0)
         {
            head=tail=newNode;


         }
        else {
            newNode.Next=head;
            head=newNode;
        }
        count++;
    }
    public void InsertLast(T value){
    
          Node<T> newNode=new Node<T>(value);
       if(count==0)
         {
            head=tail=newNode;


         }
        else {
            tail.Next=newNode;
            tail=newNode;
        }
         count++;
    }
    public void InsertAT(int pos,T  value){
        Node<T> newNode=new Node<T>(value);
        if(count==0){
            InsertFirst(value);
        }
        else if(pos==count)
            InsertLast(value); 
        else{
            Node<T> cur=head;
            for(int  i=0;i<=pos-1;++i)
               cur=cur.Next;
            newNode.Next=cur.Next;
            cur.Next=newNode;
             count++;
        }
        

    }
 public void Display(){
   Node<T> cur=head;
   while (cur!=null)
   {
    Console.WriteLine(cur.Value);
    cur=cur.Next;
   }

    
}

public void RemoveFirst(){
    if(count ==0)
       throw new InvalidOperationException("the list is empty");
    else if (count ==1)
      head=tail=null;
    else{
        head=head.Next;

    }
}
public void RemoveLast(){
     if(count ==0)
       throw new InvalidOperationException("the list is empty");
    else if (count ==1)
      head=tail=null;
    else{
      Node<T> cur=head;
      for(var i=0;i<=count-1;++i){
        cur=cur.Next;
      }
    
      head=cur;
      head.Next=null;

    }
}
public void RemoveAt(int index){
    if(count == 0)
        throw new InvalidOperationException("the list is empty");
    else if (count == 1)
        head = tail = null;
    else{
        Node<T> cur = head;
        for(int i = 0; i < index - 1; i++){
            cur = cur.Next;
        }
        cur.Next = cur.Next.Next;
    }
    count--;
}
public void Reverse(){
    Node<T> prev=null;
    Node<T> curr=head;
    Node<T> next=curr.Next;
    while(curr!=null || next!=null){
        next=curr.Next;
        curr.Next=prev;
        prev=curr;
        curr=next;
    }
    tail=head;
    head=prev;
}
// public int Search(T element){
//     Node<T> curr=head;
//     int pos=0;
//     while(curr!=null){
//       if(curr.Value==element)
//         return pos;
//       curr=curr.Next;
//       pos+=1;
//     }
//     return -1;
// }

}