import { AnJingBolerplateProjectTemplatePage } from './app.po';

describe('AnJingBolerplateProject App', function() {
  let page: AnJingBolerplateProjectTemplatePage;

  beforeEach(() => {
    page = new AnJingBolerplateProjectTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
