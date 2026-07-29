using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.WorkspacesPool
{
    [JsiiInterface(nativeType: typeof(IWorkspacesPoolCapacity), fullyQualifiedName: "aws.workspacesPool.WorkspacesPoolCapacity")]
    public interface IWorkspacesPoolCapacity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.0/docs/resources/workspaces_pool#desired_user_sessions WorkspacesPool#desired_user_sessions}.</summary>
        [JsiiProperty(name: "desiredUserSessions", typeJson: "{\"primitive\":\"number\"}")]
        double DesiredUserSessions
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWorkspacesPoolCapacity), fullyQualifiedName: "aws.workspacesPool.WorkspacesPoolCapacity")]
        internal sealed class _Proxy : DeputyBase, aws.WorkspacesPool.IWorkspacesPoolCapacity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/6.57.0/docs/resources/workspaces_pool#desired_user_sessions WorkspacesPool#desired_user_sessions}.</summary>
            [JsiiProperty(name: "desiredUserSessions", typeJson: "{\"primitive\":\"number\"}")]
            public double DesiredUserSessions
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
