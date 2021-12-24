# HCCode

## C# Study
- CLR(Common Language Runtime) 위에서 실행됨.
: 여러가지 언어 

전산학
제1원칙. 추가적인 한 layer를 추가해서 풀 수 없는 문제는 없다.

1. namespace BrainCShap{ }
- namespace는 성격이나 하는 일이 비슷한 클래스, 구조체, 인터페이스 등을 하나의 이름 아래 묶는 일을 함.
 , 중복가능한 특정한 함수 및 객체의 이름을 고유하게 정의
ex) System.Printing namespace에는 인쇄 관련 일들만

* 컴파일: 고급언어에서 저급언어로 번역하는 과정
* 빌드: 소스코드 파일을 실행할 수 있는 독립 sw 가공물로 변환하는 과정 또는 그에 대한 결과물


2. 메모리 영역
- Code: 소스코드, 기계어로 제어되는 메모리 영역
- Data: 전역변수, static변수 할당되는 영역, 프로그램 시작과 동시에 할당되고 종료되어야 소멸
- Stack: 값 형식과 관련, 처음 데이터 마지막에 나옴(LIFO), 함수 호출 완료시 데이터 제거됨, 
	컴파일 타임에 크기 결정, 아래 주소부터 주소 할당
- Heap: 참조 형식, 이진트리형식(왼->오), '}'를 만날 때 가비지 컬렉터가 데이터를 치워주는 구조, 
	런 타임에 크기 결정, 사용자 관리 영역(class, closure), 위 주소부터 할당
-> Heap과 Stack은 같은 공간 공유

* 값 형식: 값을 변수에 넣는 데이터 형식
* 참조 형식: 변수에 대한 위치(메모리 위치)를 담는 데이터 형식


3. 형변환
- 문자 -> 숫자: Parse() method 사용
ex) int a = int.Parse("12345"); float b = float.Parse("123.45");
ex) string e = "123456"; int f = Convert.ToInt32(e);
- 숫자 -> 문자: ToString() method 사용
ex) int c = 12345; string d = c.ToString();


4. 클래스 = 복합 데이터 형식
- 객체 지향 프로그래밍(OOP): 코드 내의 모든 것을 객체로 표현하고자 하는 프로그래밍 패러다임, 
- OOA / OOD / OOP (analysis, design, programming (language))
- 객체 지향언어
  (1) pure OO 
     모든 것이 객체
     Smalltalk, Ruby, squeak
     Alan Kay (Kent Beck, Ward 커닝햄)
     Agile Programming
     Duck Typing
   2) C / C++/ C#

- 함수형 언어: 
    특징: read only, 합성함수, Enumerate -> Filter -> Reduce?
    LISP, Haskell, Scheme

- 절차형 언어
    C, Pascal

- multi-paradigm 언어

3대 특성: 은닉성, 상속성, 다형성
- 클래스: 객체를 만들기 위한 청사진 
  ex) 붕어빵틀 / 인스턴스: 실제로 데이터를 담을 수 있는 실제 객체 
  ex) 붕어빵 (static한 언어에 해당)

-> 한 프로그램 안에서 인스턴스는 여러개 존재 but 클래스는 단 하나만
- 생성자: 객체 생성하는 역할, 클래스이름과 동일, 반환 형식이 없음, 생성자를 구현하지 않아도 컴파일러가 
생성자 만들어줌 but 클래스의 필드 원하는 값으로 초기화 할 수 있기 때문에 생성자 사용
ex) class 클래스이름{
	한정자 클래스이름( 매개변수 목록){ // }  //필드 //메소드 }

 const, volatile:
 a = 1
 a = 0


5. 정적 필드와 메소드
- static: 메소드나 필드가 클래스의 인스턴스가 아닌 클래스 자체에 소속되도록 지정하는 한정자
- 필드가 클래스에 소속된다 == 그 필드가 프로그램 전체에서 유일하게 존재
- static으로 한정하지 않은 필드: 자동으로 인스턴스에 소속(MyClass ob1 = new MyClass(); ob1.a = 1;)
, static 한정: 클래스에 소속(Myclass.a = 1; 로 접근 가능)
-> static 선언 시 인스턴스 만들지 않고도 바로 호출 가능 (MyClass.StaticMethod())

Q. 전역변수 안쓰고 왜 static?
-> static은 프로그램 종료 전까지 메모리 소멸x = 변수값 그대로 유지


6. 접근 한정자 
- public: 클래스의 내/외부 모든 곳
- protected: 클래스의 외부 x, 파생 클래스 접근 o
- private: 클래스 내부에서만, 파생 클래스 접근 x
- internal: 같은 어셈블리에 있는 코드에 대해서만 public으로 접근
- protected internal: 같은 어셈블리에 있는 코드에 대해서만 protected 접근

const한정자, volatile한정자(컴파일러 최적화가 임의로 코드변경하는 것 방지)


7. 오버라이딩과 다형성(Polymorphism)
- 다형성: 객체가 여러 형태를 가질 수 있음을 의미
- 오버라이딩: 상속받은 부모 클래스의 메소드를 재정의해 사용하는 것
- 오버라이딩 할 메소드가 virtual 키워드로 한정되어 있어야 함
- private로 선언한 메소드는 오버라이딩할 수 없음
- cf) 오버로딩 (overload)
int add(int a, int b);
int add(float a, float b); -> add2f (name mangling) : 컴파일러가 이름 변경함


8. 확장 메소드: 기존 클래스의 기능을 확장
- static 한정자로 수식, 첫번째 매개변수는 반드시 this 키워드+class의 인스턴스
ex) namespace 네임스페이스이름 {
	public static class 클래스이름 {
		public static  반환형식 메소드이름 ( this 대상형식 식별자, 매개변수목록) } // } }


9. 구조체 -> 안씀
- 구조체는 값 형식, 클래스는 참조 형식
- 구조체의 인스턴스는 스택에 할당되고 메모리에서 사라짐
- new 연산자를 사용하지 않아도 인스턴스 생성 가능
ex) struct 구조체이름{ //필드 //메소드 }


10. 인터페이스
- 메소드, 이벤트, 인덱서, 프로퍼티만 가질 수 있음(인터페이스는 인스턴스 가질 수 없음 
but 이 인터페이스를 상속받는 클래스의 인스턴스를 만드는 것은 가능)
- 인터페이스가 인터페이스 상속 ex) interface 파생인터페이스 : 부모인터페이스 
				{ // 추가할 메소드 목록 } 
- IEnumerator, IEnumerable
ex) interface 인터페이스이름 { 
	반환형식 메소드이름1( 매개변수목록 ); 
	반환형식 메소드이름2( 매개변수목록 );
	//.. }


11. 프로퍼티


12. 컬렉션 -> 자료구조
- using System.Collections
- object 형식 기반
 1) ArrayList 
 - Method: Add(), RemoveAt(), Insert(), Contains(), Reverse(), Sort()
 - 자료형 명시x -> 모든 데이터 타입 들어올 수 있음 -> list보다 연산속도 느림
 2) Queue: FIFO(처음들어간것이 처음 나옴)
 - Method: Enqueue(), Dequeue()
 - 입력은 뒤에서, 출력은 앞에서
 3) Stack: LIFO(마지막이 처음 나옴)
 - Method: pop(), push, peek, isEmpty()
 - 배열과 달리 상수 시간에 i번째 항목에 접근 불가 but 데이터 추가삭제는 가능
 4) Hashtable
 - Method: Add(),
 - key+value의 쌍으로 이루어진 데이터를 다룰 때 사용
 - 탐색속도 빠르고, 사용하기도 편리, 박싱/언박싱
 - 모든 데이터 타입 처리 가능
ex) Hashtable hashtable = new Hashtable();


13. 일반화 프로그래밍(Generic) = 데이터 형식을 일반화 
- 오버로딩하지 않고도 모든 형식 지원가능하도록
- 클래스나 메소드에서 사용할 내부 데이터 타입을 컴파일 시에 미리 지정하는 방법 
ex) void CopyArray( T[] src, T[] target ) {
	for( int = i = 0; i < src.Length; i++) {
		target[i] = src[i]; 
 	} 
}
CopyArray<int>(src, target);
-> CopyArray를 호출할 때 <> 사이의 T 대신 형식이름 입력하면 컴파일러가 치환해 호출
- 일반화 컬렉션
	- using System.Collections.Generic
	- 대표 클래스: List<T>, Queue<T>, Stack<T>, Dictionary<TKey, TVlaue>

	
14. 예외(Exception)
- try{ 
	// 	
	throw new Exception("예외를 던집니다.");
}catch(Excetion e){ Console.WriteLine(e.Message)};

	
15. 델리게이트
- 컴퓨터가 어떤 사건이 일어났음을 알려주면, 그 사건에 반응하는 프로그램을 만드는 방법
- 형식: 한정자 delegate 반환형식 델리게이트이름 ( 매개변수목록 );
- 일반화 델리게이트: delegate int Compare<T>(T a, T b);
- 델리게이트 체인: 델리게이트 하나가 여러개의 메소드를 동시에 참조 가능
- 익명 메소드 
	delegate (int a, int b) { return a+b; }

	
16. 람다식
- ex) Calculate calc = (a,b) => a+b; (형식 유추 기능 사용)

	
17. LINQ
- from, where, orderby, select, group by, join, 
- 모든 LINQ 쿼리식은 반드시 from 절로 시작
- 아무 형식이나 사용할 수 없고, IEnumerable<T>를 상속하므로 from 절의 데이터 원본으로 사용가능
ex) var profiles = from profile in arrProfile
	          where profile.Height < 175
	          orderby profile.Height ascending
	          select new { Name = profile.Name, InchHeight = profile.Height * 0.393 };

					    
18. Reflection
- Equals(), GetType(), ToString()

					    
19. 애트리뷰트

					    
20. Duck Typing
- 정의된 타입이 아니더라도 정의된 타입과 같은 shape를 가지고 있다면 에러 x
- dynamic 형식
- 상속관계를 이용하지 않으므로 프로그램의 동작에 관여하는 부분만 수정하면 됨

					    
21. 스레드와 태스크
- 프로세스: 실행 파일이 실행되어 메모리에 적재된 인스턴스, 하나 이상의 스레드로 구성
- 멀티스레드 
	- 장점: 응답성 높일 수 있음, 자원공유 용이, 경제성
	- 단점: 구현 까다로움, 너무 많은 스레드는 성능 저하

* lock은 사용하지 않기

