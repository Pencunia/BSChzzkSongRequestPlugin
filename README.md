# BSChzzkSongRequestPlugin
BSChzzkSongRequestPlugin for BeatSaber

## Can Use. But Not Completed
- It's not tested on other pc
- when accept<br>file exist -> select<br>file not exist -> download<br>So if you didn't have map, click one more after refresh action 

## [Release](https://github.com/Pencunia/BSChzzkSongRequestPlugin/releases)

## How To Use?
1. Download Release File
2. Input Files to Beat Saver Plugins Folder
3. Run Beat Saber
4. Exit Beat Saber
5. Edit ChzzkChat.json
    > {<br>
        "ChannelId": "",<br>
        "RequestQueOpen": true,<br>
        "RequestCommand": "!bsr",<br>
        "RequestMaxCount": 5,<br>
        "RequestList": []<br>
    }

    > ChannelId<br>
    Open your channel on Browser <br>
    Then you can get Channel Id from url https://chzzk.naver.com/"ChannelId"<br>
    input like "ChannelId": "fdas4f06fe10aw6f"

    > RequestQueOpen<br>
    Get Request On/Off<br>
    true = on<br>
    false = off

    >RequestCommand<br>
    default is !bsr but you can use any <b>word</b>.<br>
    like @aaa also can use

    >RequestMaxCount<br>
    How Many store request

    >RequestList<br>
    Don't edit this please.<br>
    It just current list

### to do list
- make floating UI and chat show here -> hold
- imoji parsing -> hold. make with above thing.
- make requested song log data
- song download bar -> On now, No information in game until refresh
- Make UI Click Event
- chzzk api is generated so need connect here
- and something more...

FrameWork : .Net FrameWork 4.7.2

아직 공식 api로 업데이트 되지 않았습니다.
아직 초보라 뭔가를 할 때마다 문제에 봉착는 중입니다.

만약 수정하고 싶으시다면 그냥 가져가서 하셔도 됩니다.<br>
유니티는 잘 몰라서 힘들어요...🥕🥕
