# PJ_BattleGround
Unity 엔진을 활용한 FPS 프로젝트

# 클래스 정리
## Managers
* 싱글톤으로 생성
* Scene, Input, Resource, Game ... 등 매니저 역할을 하는 클래스의 인스턴스를 들고 있는 클래스

## InputManager
* MovementAction : 델리게이트 Action 클래스. PlayerController에서 움직임을 업데이트하는 함수를 구독.
* Movement 함수 : wasd 입력을 받아 델리게이트 Vector3 형식을 MovementAction 델리게이트에 인자로 건냄.
* OnUpdate 함수 : Managers의 Update 함수에서 매프레임마다 실행. (Movement 함수 ...)

## PlayerController
* UpdateMoving 함수 : 인자로 받은 Vector3를 가지고 Player를 이동시킴.
* UpdateRotate 함수 : 카메라 방향으로 Player를 회전시킴. 움직임이 없을 때는 회전하지 않음.

# 이슈정리
## Managers 산하에서 기능하는 매니저 클래스들이 초기화될 때 서로 재귀적으로 호출하면서 StackOverflow가 발생.   
* GameManager에서 Player와 MainCamera를 최초에 들고 있도록 하면 다른 클래스에서 공통적으로 참조할 수 있을 것 같다고 생각해 씬에 있는 Player와 MainCamera를 프로퍼티 형식으로 들고 있도록 구현.
* 최초에 프로젝트를 실행할 때 GameManger.Init()에서 Player를 스폰하는데 Manager.GameManager.Spawn을 통해 프리팹을 인스턴스화해 씬에 배치함.
* 이 과정에서 Managers의 Init() -> GameManager.Init()을 무한히 재귀하면서 스택오버 플로가 발생

* 클래스의 기능을 의존성을 고려해서 명확히 이해하고 설계할 필요가 있었다.
* SceneManagerEx 클래스에서 현재 씬을 참조하는 멤버(CurrentScene)를 두고 BaseScene에서 Player와 Camera 정보를 들고 있도록 구현.
* 씬이 전환될 때마다 SceneManagerEx에서 CurrentScene을 초기화.
* GameManager는 CurrentScene을 통해 Player와 MainCamera 정보를 참조.