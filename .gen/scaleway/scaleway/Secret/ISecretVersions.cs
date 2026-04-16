using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace scaleway.Secret
{
    [JsiiInterface(nativeType: typeof(ISecretVersions), fullyQualifiedName: "scaleway.secret.SecretVersions")]
    public interface ISecretVersions
    {

        [JsiiTypeProxy(nativeType: typeof(ISecretVersions), fullyQualifiedName: "scaleway.secret.SecretVersions")]
        internal sealed class _Proxy : DeputyBase, scaleway.Secret.ISecretVersions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }
        }
    }
}
