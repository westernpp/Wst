#include<stdio.h>
#include<stdlib.h>
#include<string.h>
// #include"myFunction.h"
void loginPage();
void loginPrompt();
// void InsertByValue_LinkList(struct LinkNode *header);
int choice = -1;//定义一个全局变量，该变量存放的是用户选择的身份

//存放用户注册的账号密码
typedef struct LoginData
{
    char userName[20];
    char keyBoard[20];
};
//定义一个节点数据类型 -->用户注册的账号密码的节点
typedef struct LoginDataNode
{
    struct LoginData userData;
    struct LoginDataNode *next;
}node_1;

//学生成绩
struct score{
    int math;
    int english;
    int java;
    int python;
    int physics;
};
//学生信息
struct  students
{
    char name[20];
    char num[5];//学号
    char gender[5];//性别
    int sum;//总分
    int aver;
    struct score score;    
};
//定义一个节点类型数据
struct LinkNode{
    //数据域
    struct students;
    //指针域
    struct LinkNode *next;
};
struct LinkNode* header;
void loginPrompt()
{
    printf("  _______________________________________________________________________________________________________________  \n");
    printf("\n");
    printf("  *************************************************************************************************************** \n");
    printf("\n\n\n\n\n\n\n");
    printf("                                 O(∩_∩)O~欢迎使用学生信息管理系统~ O(∩_∩)O\n\n");
    printf("                                          请选择对应的身份登陆系统\n");
    printf("                                       _____________________________\n\n");
    printf("                                          --->>> 1.我是老师 <<<---\n");
    printf("                                          --->>> 2.我是学生 <<<---\n");
    // printf("                                          --->>> 3.用户注册 <<<---\n");
    printf("\n\n\n\n\n\n\n");
    printf("  *************************************************************************************************************** \n");
    printf("\n");
    printf("  _______________________________________________________________________________________________________________  \n");
    loginPage();

}

//用户登录
void loginPage()
{
    
    node_1 *newLogin();
    // int choice;
    // char workNum[20] = "03062201"; //教师工号
    // char workKey[20] = "teacher123"; //教师
    char Inset_workNum[20]; //存放用户输入的教师工号
    char Inset_workKey[20];
    char Inset_stuNum[20];
    char Inset_stuKey[20];
    while (1)
    {
        scanf("%d",&choice);
        if(choice == 1)//用户选择的身份为教师
        {
            system("cls");//清除当前屏幕所有内容
            printf("                                 请输入工号：");
            scanf("%s",&Inset_workNum);
            printf("                                 请输入密码：");
            scanf("%s",&Inset_workKey);
            printf("                                 登录成功！\n");
            return;
        }
        else if(choice == 2)
        {
            system("cls");//清除当前屏幕所有内容
            printf("                                 请输入学号:");
            scanf("%s",&Inset_stuNum);
            printf("                                 请输入密码：");
            scanf("%s",&Inset_stuKey);
            printf("                                 登录成功！\n");
            return;
        }
        // else if(choice == 3) //注册一个新账号
        // {
        //     newLogin();
        // }
        else
        {
            printf("输入无效！请重新输入");
            continue;
        }
    }
}

//用户注册-->暂时没用上
node_1 *newLogin()
{
    //初始化链表
    //创建一个头部节点
    node_1 *header = (node_1 *)malloc(sizeof(node_1));
    header->next = NULL;

    //创建一个尾部节点 默认指向头部节点
    node_1 *pRear;
	pRear = header;

    //用户输入
    char temp_userName[20];
    char temp_userKey[20];
    while (1)
    {
        printf("输入用户名：");
        scanf("%s",&temp_userName);
        printf("输入密码：");
        scanf("%s",&temp_userKey);
        break;
    }
    
    printf("%s,%s",temp_userKey,temp_userName);//没问题

    //创建新节点存放用户输入的数据
    node_1 *newNode = malloc(sizeof(node_1));
    // newNode->userData.userName = temp_userName;

    newNode->next = NULL;

    //让尾部指针指向新节点
    pRear->next = newNode;

    //更新指针
    pRear = newNode;

    printf("%p,%p",newNode->userData.userName,newNode->userData.keyBoard);

    //用户输入数据
    // while (1)
    // {
    //     printf("输入用户名：");
    //     scanf("%s",newNode->userData.userName);
    //     printf("输入密码：");
    //     scanf("%s",newNode->userData.keyBoard);
    //     char temp[20] = newNode->userData.keyBoard;//暂时存放用户输入的密码
    //     printf("确认密码：");
    //     scanf("%s",newNode->userData.keyBoard);
    //     if(temp == newNode->userData.keyBoard)
    //     {    
    //         printf("注册成功");
    //         break;
    //     }
    //     else
    //     {
    //         printf("两次输入的密码不一致！");
    //     }

    //     //
    // }
    
}


//录入学生信息
//初始化链表
struct LinkNode *Init_LinkList()
{

    if(choice == 2)
    {
        printf("  _______________________________________________________________________________________________________________  \n");
        printf("\n");
        printf("  *************************************************************************************************************** \n");
        printf("\n\n\n\n\n\n\n\n\n");
        printf("                                             您没有该权限！\n");
        printf("\n\n\n\n\n\n\n\n\n");
        printf("  *************************************************************************************************************** \n");
        printf("\n");
        printf("  _______________________________________________________________________________________________________________  \n");
        return;
    }

        int n;//判断是否继续录入学生信息

        //定义一个头部节点
        struct LinkNode *header = malloc(sizeof(struct LinkNode));//为头部节点分配一块空间
        header->next = NULL;

        //尾部指针
        struct LinkNode *pRear = header; //尾部指针默认指向头部节点

        //用户输入数据
        while (1)
        {
            system("cls");
            //创建一个新节点
            struct LinkNode *newNode = malloc(sizeof(struct LinkNode));
            newNode->next = NULL;

            printf("  _______________________________________________________________________________________________________________  \n");
            printf("\n");
            printf("  *************************************************************************************************************** \n");
            printf("\n\n\n\n");
            printf("                                                  输入学生姓名：");
            scanf("%s",newNode->name);
            printf("                                                  输入学生学号：");
            scanf("%s",newNode->num);
            printf("                                                  输入学生性别：");
            scanf("%s",newNode->gender);
            printf("                                                  输入该学生的高数成绩：");
            scanf("%d",&newNode->score.math);//int类型 输入时要用取地址符     
            printf("                                                  输入该学生的大学英语成绩：");
            scanf("%d",&newNode->score.english);
            printf("                                                  输入该学生的大学物理成绩：");
            scanf("%d",&newNode->score.physics);
            printf("                                                  输入该学生的python成绩：");
            scanf("%d",&newNode->score.python);
            printf("                                                  输入该学生的Java成绩：");
            scanf("%d",&newNode->score.java);
            printf("                                                  录入完毕,是否继续录入？(1.yes/2.no)\n");
            scanf("%d",&n);
            printf("\n\n\n\n");
            printf("  *************************************************************************************************************** \n");
            printf("\n");
            printf("  _______________________________________________________________________________________________________________  \n");

            //让尾部指针指向新节点
            pRear->next = newNode;//

            //更新节点
            pRear = newNode;

            // printf("%d\n",newNode->data);
            
            if(n==1)
            {    
                // system("cls");
                continue;
            }
            else
            {
                // //不再录入 返回菜单
                // menu();
                break;
            }
        }
        return header;
}

//增加学生信息
void InsertByValue_LinkList()
{
    if(header==NULL)
    {
        printf("暂无学生信息！");
        return;
    }
    if(choice == 2)
    {
        printf("  _______________________________________________________________________________________________________________  \n");
        printf("\n");
        printf("  *************************************************************************************************************** \n");
        printf("\n\n\n\n\n\n\n\n\n");
        printf("                                             您没有该权限！\n");
        printf("\n\n\n\n\n\n\n\n\n");
        printf("  *************************************************************************************************************** \n");
        printf("\n");
        printf("  _______________________________________________________________________________________________________________  \n");
        return;
    }
    //定义两个辅助指针
    struct LinkNode *prev = header; //一个指向头部
    struct LinkNode *pCurrent = prev->next; //另一个指向下一个节点（因为头部的next存放的就是下一个节点的地址）

    //
    printf("  _______________________________________________________________________________________________________________  \n");
    printf("\n");
    printf("  *************************************************************************************************************** \n");
    printf("\n\n\n");
        while (1)
        {
             //找到旧数据
            printf("要在学号为几的学生前面添加数据？");
            char oldVal[5];
            scanf("%s",&oldVal);
            while (pCurrent != NULL)
            {
                if( strcmp(pCurrent->num,oldVal)==0 )
                     break;//找到了就退出循环
                //没找到就让两个指针继续往后移
                prev =pCurrent;
                pCurrent = pCurrent->next;
            }
            //如果一直没找到旧数据，那么最后pCurrent的值会指向空
            if(pCurrent==NULL)
            {
                printf("没有找到学号为%s的学生！\n",oldVal);
                printf("1.重新输入\n");
                printf("2.返回菜单\n");
                int x;
                scanf("%d",&x);
                if(x==1)
                {
                    continue;
                }
                else
                {
                    break;
                }
            }   
            else
            {
                //找到旧数据后 提示用户输入新数据
                printf("请输入要插入的学生信息！\n");
                //创建一个新节点
                struct LinkNode *newNode = malloc(sizeof(struct LinkNode));
                newNode->next = NULL;
                printf("                                                  输入学生姓名：");
                scanf("%s",newNode->name);
                printf("                                                  输入学生学号：");
                scanf("%s",newNode->num);
                printf("                                                  输入学生性别：");
                scanf("%s",newNode->gender);
                printf("                                                  输入该学生的高数成绩：");
                scanf("%d",&newNode->score.math);//int类型 输入时要用取地址符     
                printf("                                                  输入该学生的大学英语成绩：");
                scanf("%d",&newNode->score.english);
                printf("                                                  输入该学生的大学物理成绩：");
                scanf("%d",&newNode->score.physics);
                printf("                                                  输入该学生的python成绩：");
                scanf("%d",&newNode->score.python);
                printf("                                                  输入该学生的Java成绩：");
                scanf("%d",&newNode->score.java);
                printf("                                                  录入完毕,是否继续录入？(1.yes/2.no)\n");
                int n;
                scanf("%d",&n);
                //把新节点放入链表
                newNode->next = pCurrent;
                prev->next = newNode;
                //判断是否继续录入信息
                if(n==1)
                    continue;
                else
                    break;
            }        
    }
    printf("\n\n\n");
    printf("  *************************************************************************************************************** \n");
    printf("\n");
    printf("  _______________________________________________________________________________________________________________  \n");
}

//查看所有学生信息 ->遍历链表
void Foranch_LinkList()
{
    if(header == NULL)
    {
        printf("暂无学生信息！");
        return;
    }
    // 定义一个赋值指针
    struct LinkNode *pCurrent = header->next;//因为头部节点不存储有效数据，所以也就不打印。直接让赋值指针指向头部节点的next就行
    
    printf("  _______________________________________________________________________________________________________________  \n");
    printf("\n");
    printf("  *************************************************************************************************************** \n");
    printf("\n\n");
    printf("                                             学生成绩\n");
    printf("\t 学号\t姓名\t性别\t高数\t大学英语    大学物理    python    Java    总分    平均分\t\n");
    while (pCurrent!=NULL)
    {
        //计算总分
        int sum=0;
        sum+=pCurrent->score.english;
        sum+=pCurrent->score.java;
        sum+=pCurrent->score.math;
        sum+=pCurrent->score.physics;
        sum+=pCurrent->score.python;
        //计算平均分
        int aver = sum/5;

        printf("\t  %s \t",pCurrent->num);
        printf("%-8s ",pCurrent->name);//让每一列左对齐 设置宽度
        printf("%-6s  ",pCurrent->gender);
        printf("%-6d   ",pCurrent->score.math);
        printf("%-6d      ",pCurrent->score.english);
        printf("%-6d      ",pCurrent->score.physics);
        printf("%-6d   ",pCurrent->score.python);
        printf("%-6d  ",pCurrent->score.java);
        printf("%-6d  ",sum);
        printf("%-6d",aver);
        printf("\n");
        pCurrent = pCurrent->next;
    }
    printf("\n\n\n\n");
    printf("  *************************************************************************************************************** \n");
    printf("\n");
    printf("  _______________________________________________________________________________________________________________  \n");
 }

//查询单个学生信息
void ForOne_LinkList()
{

    if(header == NULL)
    {
        printf("暂无学生信息！");
        return;
    }
    // 定义一个指针
    struct LinkNode *pCurrent = header->next;
    char num[5];
    printf("输入要查找的学生学号：");
    scanf("%s",&num);
    //查找
    while (pCurrent!=NULL)
    {
        // printf("输入%s\n",num);
        // printf("当前%s",pCurrent->num);
        if(strcmp(pCurrent->num,num)==0)
        {
            //计算总分
            int sum=0;
            sum+=pCurrent->score.english;
            sum+=pCurrent->score.java;
            sum+=pCurrent->score.math;
            sum+=pCurrent->score.physics;
            sum+=pCurrent->score.python;
            //计算平均分
            int aver = sum/5;

            printf("  _______________________________________________________________________________________________________________  \n");
            printf("\n");
            printf("  *************************************************************************************************************** \n");
            printf("\n\n");
            printf("                                             学生成绩\n");
            printf("\t 学号\t姓名\t性别\t高数\t大学英语    大学物理    python    Java    总分    平均分\t\n");
            printf("\t  %s \t",pCurrent->num);
            printf("%-8s ",pCurrent->name);//让每一列左对齐 设置宽度
            printf("%-6s  ",pCurrent->gender);
            printf("%-6d   ",pCurrent->score.math);
            printf("%-6d      ",pCurrent->score.english);
            printf("%-6d      ",pCurrent->score.physics);
            printf("%-6d   ",pCurrent->score.python);
            printf("%-6d  ",pCurrent->score.java);
            printf("%-6d  ",sum);
            printf("%-6d",aver);
            printf("\n");
            break;
        }
        //没有找到 则让指针指向下一个节点
        pCurrent = pCurrent->next;
    }
    //如果没有找到 最后pcurrent会为空
    if(pCurrent == NULL)
    {
        printf("没有找到学号为%s的学生!\n",num);
        printf("1.重新输入\n");
        printf("2.返回菜单");
        int x;
        scanf("%d",&x);
        if(x=2)
            menu();
    }

}

//删除某个学生信息  //删除数据
void RemoveByValue_LinkList()
{
    if(header == NULL)
    {
        printf("暂无学生信息！");
        return;
    }   
    if(choice == 2)
    {
        printf("  _______________________________________________________________________________________________________________  \n");
        printf("\n");
        printf("  *************************************************************************************************************** \n");
        printf("\n\n\n\n\n\n\n\n\n");
        printf("                                             您没有该权限！\n");
        printf("\n\n\n\n\n\n\n\n\n");
        printf("  *************************************************************************************************************** \n");
        printf("\n");
        printf("  _______________________________________________________________________________________________________________  \n");
        return;
    }
    //提示用户
    char n[5];
    printf("输入想要删除的学生的学号：");
    scanf("%s",&n);
    //定义两个辅助指针
    struct LinkNode * prev = header;
    struct LinkNode * pCurrent = header->next;
    //遍历寻找要删除的数据
    while (pCurrent != NULL)
    {
        if(strcmp(pCurrent->num,n)==0) //找到了要删除的数据就退出遍历
         {
            break;
         }
        //没有找到，就让两个辅助指针往后移动
        prev = pCurrent;
        pCurrent = pCurrent->next;
    }
    //如果遍历完链表都没找到要删除的数据，那么pCurrent的值最后会为空
    if(pCurrent == NULL)
    {
        printf("没有找到该学生！\n");
        return 0;
    }
    else
    {
        //让待删除节点的前驱节点指向待删除节点的后续节点 
        // 这样待删除节点在链表中没有被指向，也就等于被孤立了，我们无法再找到这个待删除节点
        prev->next = pCurrent->next;
        //释放待删除节点的内存
        free(pCurrent);
         pCurrent = NULL;
         printf("删除成功！\n");
    }
        
}

//清空所有学生信息   //清空链表
void Clear_LinkList()
{
    if(header == NULL)
    {
        printf("暂无学生信息！");
        return;
    }
    if(choice == 2)
    {
        printf("  _______________________________________________________________________________________________________________  \n");
        printf("\n");
        printf("  *************************************************************************************************************** \n");
        printf("\n\n\n\n\n\n\n\n\n");
        printf("                                             您没有该权限！\n");
        printf("\n\n\n\n\n\n\n\n\n");
        printf("  *************************************************************************************************************** \n");
        printf("\n");
        printf("  _______________________________________________________________________________________________________________  \n");
        return;
    }
    //定义一个辅助指针
    struct LinkNode *pCurrent;
    pCurrent = header->next;
    while (pCurrent!=NULL)
    {
        //先创建一个新节点，用来暂存下一个节点
        struct LinkNode *pNext = pCurrent->next;
        //释放pCurrent当前数据
        free(pCurrent);
        //让pCurrent指向下一个节点，也就是我们刚刚暂存的节点
        pCurrent = pNext;
    }
    header->next = NULL;
    printf("清空成功！\n");
}

//保存学生信息
void save()
{
    if(header==NULL)
    {
        printf("暂无学生信息！\n");
        return;
    }
    FILE* f;
    f=fopen("studentsystem.xls","w");
    if(f==NULL)
    {
        printf("保存失败!\n");
        return;
    }
    //定义一个辅助指针
    struct LinkNode *pCurrent = header->next;
    //
    if(header == NULL)
        printf("暂无学生信息！\n");
    else
    {
        while (pCurrent!=NULL)
        {
            //计算总分
            int sum=0;
            sum+=pCurrent->score.english;
            sum+=pCurrent->score.java;
            sum+=pCurrent->score.math;
            sum+=pCurrent->score.physics;
            sum+=pCurrent->score.python;
            //计算平均分
            int aver = sum/5;
            // fprintf(f,"姓名:%s\n",t->student.name);
            fprintf(f,"学号\t姓名\t性别\t高数\t大学英语t\t大学物理\tpython\tJava\t总分\t平均分\t\n");
            fprintf(f,"%s\t ",pCurrent->num);
            fprintf(f,"%s\t",pCurrent->name);
            fprintf(f,"%s\t",pCurrent->gender);
            fprintf(f,"%d\t",pCurrent->score.math);
            fprintf(f,"%d\t",pCurrent->score.english);
            fprintf(f,"%d\t",pCurrent->score.physics);
            fprintf(f,"%d\t",pCurrent->score.python);
            fprintf(f,"%d\t",pCurrent->score.java);
            fprintf(f,"%d\t",sum);
            fprintf(f,"%d\t",aver);
            fprintf(f,"\n");

            pCurrent = pCurrent->next;
        }
        printf("保存成功！！");
    }
    
    
    fclose(f);
}

//退出系统->回到登录选择界面
void back()
{
    loginPrompt();
}

//菜单
int menu()
{
    system("cls");
    printf("  _______________________________________________________________________________________________________________  \n");
    printf("\n");
    printf("  *************************************************************************************************************** \n");
    printf("                                                                                      登录成功！您的身份为：");
    if(choice == 1)
        printf("教师\n\n");
    else
        printf("学生\n\n");
    printf("\n\n\n\n");
    printf("                                 O(∩_∩)O~欢迎使用学生信息管理系统~ O(∩_∩)O\n\n");
    printf("                                          >>>请选择要进行的操作：<<<\n");
    printf("                                           _______________________\n\n");
    printf("                                           1.录入学生信息\n");
    printf("                                           2.增加学生信息\n");
    printf("                                           3.删除单个学生信息\n");
    printf("                                           4.查询单个学生信息\n");
    printf("                                           5.查询所有学生信息\n");
    printf("                                           6.清空所有学生信息\n");
    printf("                                           7.保存学生信息\n");
    printf("                                           8.退出登录\n");
    printf("                                           9.退出系统\n");
    printf("\n\n\n\n");
    printf("  *************************************************************************************************************** \n");
    printf("  _______________________________________________________________________________________________________________  \n");
    //存放用户输入的选择
    int n;
    scanf("%d",&n);
   return n;
}
int main()
{
    loginPrompt();
    int n;
    
     while (1)
    {
        n = menu();
        switch (n)
        {
            case 1:
                system("cls");
                header = Init_LinkList();
                system("pause");//程序暂停 按任意键继续
                system("cls");
                break; 
            case 2:
                system("cls");
                InsertByValue_LinkList();
                system("pause");
                system("cls");
                break;
            case 3:
                system("cls");
                RemoveByValue_LinkList();
                system("pause");
                system("cls");
                break;
            case 4:
            system("cls");
                ForOne_LinkList();
                system("pause");
                system("cls");
                break;
            case 5:
                system("cls");
                Foranch_LinkList();
                system("pause");
                system("cls");
                break;
            case 6:
                system("cls");
                Clear_LinkList();
                system("pause");
                system("cls");
                break;
            case 7:
                system("cls");
                save();
                system("pause");
                system("cls");
                break;
            case 8:
                system("cls");
                back();
                system("pause");
                system("cls");   
                break;
            case 9:
                system("cls");
                printf("\n\n\nn\n\n\n");
                printf("  _______________________________________________________________________________________________________________  \n");
                printf("\n");
                printf("  *************************************************************************************************************** \n");
                printf("\n\n\n\n");
                printf("                                          O(∩_∩)O~感谢使用！ O(∩_∩)O~\n");
                printf("\n\n\n\n");
                printf("  *************************************************************************************************************** \n");
                printf("  _______________________________________________________________________________________________________________  \n");
                return;     
        }

    }
}    