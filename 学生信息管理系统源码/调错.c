#include<stdio.h>
#include<stdlib.h>
#include<string.h>
#include"myFunction.h"
void loginPage();
void loginPrompt();
// void InsertByValue_LinkList(struct LinkNode *header);
int choice = -1;//定义一个全局变量，该变量存放的是用户选择的身份

//存放用户注册的信息
struct LoginData
{
    char userName[20];
    char keyBoard[20];
    int who;//身份
};
//定义一个节点数据类型 -->用户注册的账号密码的节点
typedef struct LoginDataNode
{
    struct LoginData userData;
    struct LoginDataNode *next;
}node_1;

//用户注册
//时间：2023/2/17 16：52
//问题描述：编译成功 但运行时输入3 调用该函数 没有效果
//原因：调用函数的时候把类型名也写上了。。
//时间：2023/2/20 用户的注册功能不全 无法把用户的注册信息保存在链表中
node_1 *newLogin()
{
    //初始化链表
    //定义一个头部节点
    node_1* loginHeader = malloc(sizeof(node_1));
    loginHeader->next = NULL;
    //定义一个尾部节点
    node_1* pRear = loginHeader;
    //提示用户输入
    while (1)
    {
        //创建一个新节点存放数据
        node_1* newLoginNode = malloc(sizeof(node_1));
        newLoginNode->next==NULL;
        printf("您是：(1.老师/2.学生)\n");
        scanf("%d",&newLoginNode->userData.who);
        printf("输入用户名：");
        scanf("%s",newLoginNode->userData.userName);
        printf("输入密码:");
        char tempKey[20];//临时存放用户输入的密码
        gets(tempKey);
        printf("确认密码：");
        scanf("%s",newLoginNode->userData.keyBoard);
        printf("temp=%s\n",tempKey);
        printf("->=%s",newLoginNode->userData.keyBoard);
        //判断两次输入的密码是否一致
        if(strcmp(tempKey,newLoginNode->userData.keyBoard)==0)
        {
            printf("注册成功！\n");
            //让尾部指针指向新节点
            pRear->next = newLoginNode;
            //更新指针
            pRear = newLoginNode;
            loginPrompt();
            break;
        }
        else
        {
            printf("两次输入的密码不一致！\n");
            continue;
        }
    }
    //把用户注册完的数据返回给调用函数
    return loginHeader;
}
//登录选择界面
void loginPrompt()
{
    system("cls");
    printf("  _______________________________________________________________________________________________________________  \n");
    printf("\n");
    printf("  *************************************************************************************************************** \n");
    printf("\n\n\n\n\n\n\n");
    printf("                                 O(∩_∩)O~欢迎使用学生信息管理系统~ O(∩_∩)O\n\n");
    printf("                                          请选择对应的身份登陆系统\n");
    printf("                                       _____________________________\n\n");
    printf("                                          --->>> 1.我是老师 <<<---\n");
    printf("                                          --->>> 2.我是学生 <<<---\n");
    printf("                                          --->>> 3.用户注册 <<<---\n");
    printf("\n\n\n\n\n\n\n");
    printf("  *************************************************************************************************************** \n");
    printf("  _______________________________________________________________________________________________________________  \n");
    loginPage();
    //
    // node_1* loginHeader = malloc(sizeof(node_1));
    // loginHeader->next=NULL;
    // loginPage(loginHeader);

}
//登录界面
void loginPage()
{

    /*
        定义一个新的节点存放用户注册的账号密码，
        如果用户要选择老师/学生其中某一身份登录系统,需要在链表中查询用户是否有注册过该账号
    */
    node_1* dataHeader = malloc(sizeof(node_1));
    dataHeader = NULL;
   //
   char uname[20];
   char key[20];
   while (1)
   {
        scanf("%d",&choice);
        if(choice == 1)//老师登录
        {
            printf("请输入工号：");
            scanf("%s",&uname);
            printf("请输入密码：");
            scanf("%s",&key);
            //用户输入账号密码后，需要遍历链表，查找链表中是否有存放这个账号密码
            if(dataHeader == NULL)
            {
                printf("不存在该用户！\n");
            }
            else
            {
                //dataHeader里有数据，则遍历链表
                while (dataHeader!=NULL)
                {
                    //判断用户密码及身份是否对应
                    if(strcmp(uname,dataHeader->userData.userName)==0 && strcmp(key,dataHeader->userData.keyBoard) && choice==dataHeader->userData.who)
                    {
                        printf("登录成功！\n");
                        break;
                    }
                    else
                    {
                        printf("用户名或密码错误！\n");
                        // loginPrompt();
                        break;
                    }
                    dataHeader = dataHeader->next;
                }
                
            }
        }  
        else if(choice == 2)//学生登录
        {
            printf("请输入学号：");
            scanf("%s",&uname);
            printf("请输入密码：");
            scanf("%s",&key);
            //用户输入账号密码后，需要遍历链表，查找链表中是否有存放这个账号密码
            if(dataHeader == NULL)
            {
                printf("不存在该用户！\n");
            }
            else
            {
                //dataHeader里有数据，则遍历链表
                while (1)
                {
                    //判断用户密码及身份是否对应
                    if(strcmp(uname,dataHeader->userData.userName)==0 && strcmp(key,dataHeader->userData.keyBoard) && choice==dataHeader->userData.who)
                    {
                        printf("登录成功！\n");
                        break;
                    }
                    else
                    {
                        printf("用户名或密码错误！\n");
                        loginPrompt();
                        break;
                    }
                }               
            }
        }
        else //注册新账号
        {
            //调用注册账号的函数
            dataHeader = newLogin();           
        }
   }
   
   
}



int main()
{
    loginPrompt();
    loginPage();
}