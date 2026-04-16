using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace cloudflare.User
{
    [JsiiInterface(nativeType: typeof(IUserOrganizations), fullyQualifiedName: "cloudflare.user.UserOrganizations")]
    public interface IUserOrganizations
    {

        [JsiiTypeProxy(nativeType: typeof(IUserOrganizations), fullyQualifiedName: "cloudflare.user.UserOrganizations")]
        internal sealed class _Proxy : DeputyBase, cloudflare.User.IUserOrganizations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
