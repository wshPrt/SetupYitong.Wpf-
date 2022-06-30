using Prism.Ioc;
using SetupYitong.Wpf.Interface;
using SetupYitong.Wpf.ViewModels;
using SetupYitong.Wpf.Views;
using System;
using System.Windows;

namespace SetupYitong.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            try
            {
                var mw = Container.Resolve<MainWindow>();
                var win = Container.Resolve<SignIn>();
                var a = win.ShowDialog();
                if (a.HasValue && a.Value)
                {
                    return mw;
                }
                return win;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<SignIn>();
            containerRegistry.RegisterForNavigation<TopNavigation>();
            containerRegistry.RegisterForNavigation<LeftNavigation>();
            containerRegistry.RegisterForNavigation<Project>();
            containerRegistry.RegisterForNavigation<ProjectWareHouse>();
            containerRegistry.RegisterForNavigation<ProjectRelatedInfo>();
            containerRegistry.RegisterForNavigation<ProbjectSetting>();
            containerRegistry.RegisterForNavigation<ProjectRelated>();
            containerRegistry.RegisterForNavigation<ProbjectAnimationDesign>();
            containerRegistry.RegisterForNavigation<NewTask>();
            containerRegistry.RegisterForNavigation<FileHome>();
            containerRegistry.RegisterForNavigation<FileList>();
            containerRegistry.RegisterForNavigation<DeleteFile>();
            containerRegistry.RegisterForNavigation<FileDetails>();
            containerRegistry.RegisterForNavigation<Team>();
            containerRegistry.RegisterForNavigation<Setup>();
            containerRegistry.RegisterForNavigation<HelpHome>();
            containerRegistry.RegisterForNavigation<HelpCourse>();
            containerRegistry.RegisterForNavigation<Register>();
            containerRegistry.RegisterForNavigation<RegisterResult>();
            containerRegistry.RegisterForNavigation<UploadPointsMirror>();
            containerRegistry.RegisterForNavigation<NewGeneralTask>();
            containerRegistry.RegisterForNavigation<UploadFiles>();
            
            //弹窗遮罩
            containerRegistry.Register<IDialogHostService, DialogHostService>();
            containerRegistry.RegisterForNavigation<SelectTemplate>();
            containerRegistry.RegisterDialog<SelectTemplate, SelectTemplateViewModel>();
            containerRegistry.RegisterForNavigation<TemplateDetails>();
            containerRegistry.RegisterDialog<TemplateDetails, TemplateDetailsViewModel>();
            containerRegistry.RegisterForNavigation<ProjectDetails>();
            containerRegistry.RegisterDialog<ProjectDetails, ProjectDetailsViewModel>();
            containerRegistry.RegisterForNavigation<DeleteProjectWarn>();
            containerRegistry.RegisterDialog<DeleteProjectWarn, DeleteProjectWarnViewModel>();
            containerRegistry.RegisterForNavigation<ProjectArchive>();
            containerRegistry.RegisterDialog<ProjectArchive, ProjectArchiveViewModel>();
            containerRegistry.RegisterForNavigation<NewProcess>();
            containerRegistry.RegisterDialog<NewProcess, NewProcessViewModel>();
            containerRegistry.RegisterForNavigation<TaskDetails>();
            containerRegistry.RegisterDialog<TaskDetails, TaskDetailsViewModel>();
            containerRegistry.RegisterForNavigation<SettingTaskStatus>();
            containerRegistry.RegisterDialog<SettingTaskStatus, SettingTaskStatusViewModel>();
            containerRegistry.RegisterForNavigation<TaskFeedBack>();
            containerRegistry.RegisterDialog<TaskFeedBack, TaskFeedBackViewModel>();
            containerRegistry.RegisterForNavigation<UserDetails>();
            containerRegistry.RegisterDialog<UserDetails, UserDetailsViewModel>();
            containerRegistry.RegisterForNavigation<DataModify>();
            containerRegistry.RegisterDialog<DataModify, DataModifyViewModel>();
            containerRegistry.RegisterForNavigation<InvitedUsers>();
            containerRegistry.RegisterDialog<InvitedUsers, InvitedUsersViewModel>();
            containerRegistry.RegisterForNavigation<ImportUser>();
            containerRegistry.RegisterDialog<ImportUser, ImportUserViewModel>();
            containerRegistry.RegisterForNavigation<AnimationDetails>();
            containerRegistry.RegisterDialog<AnimationDetails, AnimationDetailsViewModel>();
            containerRegistry.RegisterForNavigation<ConfirmTips>();
            containerRegistry.RegisterDialog<ConfirmTips, ConfirmTipsViewModel>();
            containerRegistry.RegisterForNavigation<VersionHistory>();
            containerRegistry.RegisterDialog<VersionHistory, VersionHistoryViewModel>();
            containerRegistry.RegisterForNavigation<FileDetails>();
            containerRegistry.RegisterDialog<FileDetails, FileDetailsViewModel>();
            containerRegistry.RegisterForNavigation<ShortcutsFileDetails>();
            containerRegistry.RegisterDialog<ShortcutsFileDetails, ShortcutsFileDetailsViewModel>();
            containerRegistry.RegisterForNavigation<NewGroup>();
            containerRegistry.RegisterDialog<NewGroup, NewGroupViewModel>();
            containerRegistry.RegisterForNavigation<SelectMembers>();
            containerRegistry.RegisterDialog<SelectMembers, SelectMembersViewModel>();
            
        }
    }
}
