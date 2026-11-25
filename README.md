<p align="center">
  <a href="https://archnet-plateform.fr"><img src="https://archnet-plateform.fr/ArchNetLogoWithBck.png" alt="ArchNet" width="240"></a>
</p>

# ArchNet · Reverse Mask 2D Extension

Darkens the whole UI with an overlay except the elements you highlight, which are drawn above it (tutorials).

- Unity **6000.0** or newer · Needs `com.archnet.extension.canvas` (the ArchNet installer adds them for you).
- Part of [ArchNet](https://archnet-plateform.fr), free and open-source Unity packages

## Install

*Window > Package Manager > + > Install package from git URL…*

```
https://github.com/ArchNet-1/ReverseMask2DExtension.git
```

## Use

Put **Reverse Mask 2D Controller** on the overlay's parent and **Reverse Mask 2D** on the elements to highlight, then call `controller.Highlight(mask)` / `Clear()`. Each mask has an **On Click** event.

## License

See [LICENSE.md](LICENSE.md).
